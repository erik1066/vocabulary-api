using System;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Spark.Engine.Extensions;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.Services;
using Microsoft.Extensions.Logging;

namespace Cdc.Vocabulary.WebApi.Controllers
{
    /// <summary>
    /// Index route controller class
    /// </summary>
    [ApiController]
    [Route("api/fhir")]
    [AllowAnonymous]
    public sealed class FhirController : ControllerBase
    {
        #region Private Members
        private readonly ILogger<FhirController> _logger;
        private readonly IValueSetRepository _valueSetRepository;
        private readonly IValueSetVersionRepository _valueSetVersionRepository;
        private readonly IValueSetConceptRepository _valueSetConceptRepository;
        private readonly ICodeSystemRepository _codeSystemRepository;

        private static FhirJsonSerializer _fhirJsonSerializer = new FhirJsonSerializer(new SerializerSettings()
        {
            Pretty = true
        });

        private static CapabilityStatement _capabilityStatement = new CapabilityStatement()
        {
            FhirVersion = FHIRVersion.N4_0_1,
            Status = PublicationStatus.Active,
            Date = new DateTime(2020, 01, 01).ToString(), // TODO: Convert to proper FHIR date time string
            Format = new List<string>() { "json "},
            Rest = new List<CapabilityStatement.RestComponent>() { 
                new CapabilityStatement.RestComponent() 
                {
                    Mode = CapabilityStatement.RestfulCapabilityMode.Server,
                    Resource = new List<CapabilityStatement.ResourceComponent>()
                    {
                        new CapabilityStatement.ResourceComponent()
                        {
                            Type = ResourceType.ValueSet,
                            Interaction = new List<CapabilityStatement.ResourceInteractionComponent>() 
                            {
                                new CapabilityStatement.ResourceInteractionComponent()
                                {
                                    Code = CapabilityStatement.TypeRestfulInteraction.Read
                                },
                                new CapabilityStatement.ResourceInteractionComponent()
                                {
                                    Code = CapabilityStatement.TypeRestfulInteraction.Vread
                                },
                                new CapabilityStatement.ResourceInteractionComponent()
                                {
                                    Code = CapabilityStatement.TypeRestfulInteraction.SearchType
                                }
                            }
                        }
                    }
                }
            }
        };
        #endregion // Private Members

        public FhirController(
            ILogger<FhirController> logger,
            IValueSetRepository valueSetRepository,
            IValueSetVersionRepository valueSetVersionRepository,
            IValueSetConceptRepository valueSetConceptRepository,
            ICodeSystemRepository codeSystemRepository)
        {
            _logger = logger;
            _valueSetRepository = valueSetRepository;
            _valueSetVersionRepository = valueSetVersionRepository;
            _valueSetConceptRepository = valueSetConceptRepository;
            _codeSystemRepository = codeSystemRepository;
        }
        
        // GET api/fhir/metadata
        /// <summary>
        /// Gets the capabilities statement of this server
        /// </summary>
        /// <returns>Capabilities statement</returns>
        [HttpGet("metadata")]
        [Produces("application/json")]
        public IActionResult Metadata()
        {
            string fhirContent = _fhirJsonSerializer.SerializeToString(_capabilityStatement);
            return Content(fhirContent);
        }

        // GET api/fhir/[type]/[id] {?_format=[mime-type]}
        /// <summary>
        /// Gets a resource by its ID
        /// </summary>
        /// <remarks>
        /// See https://www.hl7.org/fhir/http.html#read
        /// </remarks>
        /// <returns>FHIR Resource</returns>
        [HttpGet("{type}/{id}")]
        [Produces("application/json")]
        public IActionResult GetResourceById(string type, string id)
        {
            throw new NotImplementedException();
        }

        // GET api/fhir/[type]/[id] {?_format=[mime-type]}
        /// <summary>
        /// Gets a resource by its ID
        /// </summary>
        /// <remarks>
        /// See https://www.hl7.org/fhir/http.html#vread
        /// </remarks>
        /// <returns>FHIR Resource</returns>
        [HttpGet("{type}/{id}/_history/{vid}")]
        [Produces("application/json")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 86_400, NoStore = false)]
        public IActionResult GetVersionedResourceById(string type, string id, string vid)
        {
            if (!type.Equals("ValueSet", StringComparison.OrdinalIgnoreCase))
            {
                return NotFound();
            }

            Guid versionGuid = new Guid(vid);
            Guid valueSetGuid = new Guid(id);

            var valueSetVersionFromRepo = _valueSetVersionRepository.GetValueSetVersion(versionGuid);
            var valueSetFromRepo = _valueSetRepository.GetValueSet(valueSetGuid);

            if (valueSetFromRepo.ValueSetOID != valueSetVersionFromRepo.ValueSetOID)
            {
                return NotFound();
            }

            var valueSet = BuildValueSet(valueSetVersionFromRepo, valueSetFromRepo);

            string fhirContent = _fhirJsonSerializer.SerializeToString(valueSet);
            return Content(fhirContent);
        }

        // GET api/fhir/[type]{?[parameters]{&_format=[mime-type]}}
        /// <summary>
        /// Searches FHIR resources
        /// </summary>
        /// <remarks>
        /// See https://www.hl7.org/fhir/http.html#search
        /// </remarks>
        /// <returns>FHIR Resources</returns>
        [HttpGet("{type}")]
        [Produces("application/json")]
        public IActionResult SearchResources(string type)
        {
            var searchparams = Request.GetSearchParams();
            throw new NotImplementedException();
        }

        #region Private methods
        private ValueSet BuildValueSet(Entities.ValueSetVersion valueSetVersionFromRepo, Entities.ValueSet valueSetFromRepo)
        {
            var valueSet = new Hl7.Fhir.Model.ValueSet();
            valueSet.Identifier = new List<Identifier>()
            {
                new Identifier()
                {
                    Use = Identifier.IdentifierUse.Official,
                    Value = valueSetVersionFromRepo.ValueSetVersionID.ToString(),
                    System = "urn:ietf:rfc:3986"
                },
                new Identifier()
                {
                    Use = Identifier.IdentifierUse.Secondary,
                    Value = valueSetVersionFromRepo.ValueSetOID
                },
                new Identifier()
                {
                    Use = Identifier.IdentifierUse.Secondary,
                    Value = valueSetVersionFromRepo.ValueSetCode
                }
            };
            valueSet.Name = valueSetFromRepo.ValueSetName;
            valueSet.Publisher = "PHIN_VADS";
            valueSet.DateElement = new FhirDateTime(valueSetVersionFromRepo.StatusDate);
            valueSet.Version = valueSetVersionFromRepo.ValueSetVersionNumber.ToString();
            valueSet.VersionId = valueSetVersionFromRepo.ValueSetVersionID.ToString();
            valueSet.Expansion = new ValueSet.ExpansionComponent()
            {
                Identifier = Guid.NewGuid().ToString(),
                TimestampElement = new FhirDateTime(DateTimeOffset.Now),
                Contains = new List<ValueSet.ContainsComponent>()
            };
            valueSet.Status = PublicationStatus.Active;

            var paginationParameters = new ValueSetConceptPaginationParameters()
            {
                ValueSetVersionId = valueSetVersionFromRepo.ValueSetVersionID,
                ValueSetVersionNumber = valueSetVersionFromRepo.ValueSetVersionNumber.ToString(),
                PageSize = 1000
            };
            var valueSetConceptEntities = _valueSetConceptRepository.GetValueSetConcepts(paginationParameters);

            foreach (var conceptFromRepo in valueSetConceptEntities)
            {
                var component = new ValueSet.ContainsComponent()
                {
                    Code = conceptFromRepo.ConceptCode,
                    Display = conceptFromRepo.CDCPreferredDesignation,
                    System = $"urn:oid:{conceptFromRepo.CodeSystemOID}",
                    Extension = new List<Extension>()
                    {
                        new Extension()
                        {
                            Value = new FhirString(conceptFromRepo.HL70396Identifier)
                        }
                    }
                };
                valueSet.Expansion.Contains.Add(component);
            }

            valueSet.Expansion.Total = valueSet.Expansion.Contains.Count;
            valueSet.Expansion.Offset = paginationParameters.PageNumber - 1;

            return valueSet;
        }
        #endregion // Private methods
    }
}