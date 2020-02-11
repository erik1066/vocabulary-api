using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spark.Engine.Extensions;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.Services;
using Cdc.Vocabulary.WebApi.Helpers;
using System.Dynamic;

namespace Cdc.Vocabulary.WebApi.Controllers
{
    /// <summary>
    /// Fhir controller class
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
            Format = new List<string>() { "json" },
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
        /// Gets a value set by its ID
        /// </summary>
        /// <remarks>
        /// See https://www.hl7.org/fhir/http.html#read
        /// </remarks>
        /// <returns>FHIR ValueSet</returns>
        [HttpGet("{type}/{id}")]
        [Produces("application/fhir+json")]
        public IActionResult GetValueSetById(string type, string id)
        {
            return GetVersionedValueSetById(type, id, "latest");
        }

        // GET api/fhir/[type]/[id] {?_format=[mime-type]}
        /// <summary>
        /// Gets a value set by its ID
        /// </summary>
        /// <remarks>
        /// See https://www.hl7.org/fhir/http.html#vread
        /// </remarks>
        /// <returns>FHIR ValueSet</returns>
        [HttpGet("{type}/{id}/_history/{vid}", Name = "GetVersionedValueSetById")]
        [Produces("application/fhir+json")]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 86_400, NoStore = false)]
        public IActionResult GetVersionedValueSetById(string type, string id, string vid)
        {
            if (!type.Equals("ValueSet", StringComparison.OrdinalIgnoreCase))
            {
                return NotFound();
            }

            var (valueSetFromRepo, valueSetVersionFromRepo) = GetValueSetEntities(id, vid);
            if (valueSetFromRepo == null || valueSetVersionFromRepo == null || valueSetFromRepo.ValueSetOID != valueSetVersionFromRepo.ValueSetOID)
            {
                return NotFound();
            }

            var valueSet = BuildValueSet(valueSetVersionFromRepo, valueSetFromRepo, includeConcepts: true);

            string fhirContent = _fhirJsonSerializer.SerializeToString(valueSet);
            return Content(fhirContent, "application/fhir+json");
        }

        // GET api/fhir/[type]{?[parameters]{&_format=[mime-type]}}
        /// <summary>
        /// Searches FHIR ValueSet resources
        /// </summary>
        /// <remarks>
        /// See https://www.hl7.org/fhir/http.html#search
        /// </remarks>
        /// <returns>FHIR Bundle</returns>
        [HttpGet("{type}", Name = "SearchValueSets")]
        [Produces("application/json")]
        public IActionResult SearchValueSets(
            [FromRoute] string type,
            [FromQuery] Dictionary<string, string> parameters)
        {
            var searchparams = Request.GetSearchParams();
            Bundle searchBundle = new Bundle()
            {
                Type = Bundle.BundleType.Searchset,
                Entry = new List<Bundle.EntryComponent>(),
            };

            var valueSetVersions = _valueSetVersionRepository.GetValueSetVersions(parameters);

            foreach (var valueSetVersionFromRepo in valueSetVersions)
            {
                var valueSetFromRepo = _valueSetRepository.GetValueSet(valueSetVersionFromRepo.ValueSetCode);
                ValueSet valueSet = BuildValueSet(valueSetVersionFromRepo, valueSetFromRepo, includeConcepts: false);
                Bundle.EntryComponent entry = new Bundle.EntryComponent();
                entry.Resource = valueSet;
                searchBundle.Entry.Add(entry);
            }
            
            var selfPageLink = CreateValueSetResourceUri(parameters, ResourceUriType.SelfPage, null);
            var firstPageLink = CreateValueSetResourceUri(parameters, ResourceUriType.FirstPage, null);
            var previousPageLink = CreateValueSetResourceUri(parameters, ResourceUriType.PreviousPage, null);
            var nextPageLink = CreateValueSetResourceUri(parameters, ResourceUriType.NextPage, null);
            var lastPageLink = CreateValueSetResourceUri(parameters, ResourceUriType.LastPage, valueSetVersions.TotalPages);

            if (parameters.ContainsKey("_count") && int.TryParse(parameters["_count"], out int count) && valueSetVersions.Count < count)
            {
                nextPageLink = string.Empty;
            }

            searchBundle.Link.Add(new Bundle.LinkComponent()
            {
                Relation = "self",
                Url = selfPageLink
            });

            searchBundle.Link.Add(new Bundle.LinkComponent()
            {
                Relation = "first",
                Url = firstPageLink
            });
            
            searchBundle.Link.Add(new Bundle.LinkComponent()
            {
                Relation = "prev",
                Url = previousPageLink
            });

            searchBundle.Link.Add(new Bundle.LinkComponent()
            {
                Relation = "next",
                Url = nextPageLink
            });

            searchBundle.Link.Add(new Bundle.LinkComponent()
            {
                Relation = "last",
                Url = lastPageLink
            });

            searchBundle.Total = valueSetVersions.TotalCount;

            string fhirContent = _fhirJsonSerializer.SerializeToString(searchBundle);
            return Content(fhirContent, "application/fhir+json");
        }

        #region Private methods
        private string CreateValueSetResourceUri(Dictionary<string, string> parameters, ResourceUriType type, int? totalPages = null)
        {
            int page = 0;
            if (parameters.ContainsKey("_page"))
            {
                int.TryParse(parameters["_page"], out page);
            }

            int previousPageNumber = page - 1;
            int nextPageNumber = page + 1;

            if (type == ResourceUriType.PreviousPage && previousPageNumber <= 0)
            {
                return string.Empty;
            }

            Dictionary<string, string> firstParameters = new Dictionary<string, string>();
            foreach (var kvp in parameters)
            {
                firstParameters.Add(kvp.Key, kvp.Value);
            }

            Dictionary<string, string> prevParameters = new Dictionary<string, string>();
            foreach (var kvp in parameters)
            {
                prevParameters.Add(kvp.Key, kvp.Value);
            }

            Dictionary<string, string> nextParameters = new Dictionary<string, string>();
            foreach (var kvp in parameters)
            {
                nextParameters.Add(kvp.Key, kvp.Value);
            }

            Dictionary<string, string> lastParameters = new Dictionary<string, string>();
            foreach (var kvp in parameters)
            {
                lastParameters.Add(kvp.Key, kvp.Value);
            }

            if (firstParameters.ContainsKey("_page"))
            {
                firstParameters["_page"] = "1";
            }

            if (prevParameters.ContainsKey("_page"))
            {
                prevParameters["_page"] = previousPageNumber.ToString();
            }

            if (nextParameters.ContainsKey("_page"))
            {
                nextParameters["_page"] = nextPageNumber.ToString();
            }

            if (lastParameters.ContainsKey("_page"))
            {
                lastParameters["_page"] = totalPages.HasValue ? totalPages.Value.ToString() : string.Empty;
            }

            firstParameters.Add("type", "ValueSet");
            nextParameters.Add("type", "ValueSet");
            prevParameters.Add("type", "ValueSet");
            lastParameters.Add("type", "ValueSet");

            dynamic first = firstParameters.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
              (a, p) => { a.Add(p.Key, p.Value); return a; });

            dynamic prev = prevParameters.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
              (a, p) => { a.Add(p.Key, p.Value); return a; });

            dynamic next = nextParameters.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
              (a, p) => { a.Add(p.Key, p.Value); return a; });

            dynamic last = lastParameters.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
              (a, p) => { a.Add(p.Key, p.Value); return a; });

            dynamic self = parameters.Aggregate(new ExpandoObject() as IDictionary<string, Object>,
              (a, p) => { a.Add(p.Key, p.Value); return a; });

            switch (type)
            {
                case ResourceUriType.FirstPage:
                    return Url.Link(nameof(SearchValueSets),
                    first);
                case ResourceUriType.PreviousPage:
                    return Url.Link(nameof(SearchValueSets),
                    prev);
                case ResourceUriType.NextPage:
                    return Url.Link(nameof(SearchValueSets),
                    next);
                case ResourceUriType.LastPage:
                    return Url.Link(nameof(SearchValueSets),
                    last);
                case ResourceUriType.SelfPage:
                    return Url.Link(nameof(SearchValueSets),
                    self);
                default:
                    throw new InvalidOperationException();
            }
        }

        private (Entities.ValueSet ValueSetFromRepo, Entities.ValueSetVersion ValueSetVersionFromRepo) GetValueSetEntities(string id, string vid)
        {
            Entities.ValueSet valueSetFromRepo = new Entities.ValueSet();
            Entities.ValueSetVersion valueSetVersionFromRepo = new Entities.ValueSetVersion();

            bool isIdValidGuid = Guid.TryParse(id, out Guid valueSetGuid);
            if (isIdValidGuid)
            {
                valueSetFromRepo = _valueSetRepository.GetValueSet(valueSetGuid);
            }
            else
            {
                valueSetFromRepo = _valueSetRepository.GetValueSet(id);
            }

            bool isVidValidGuid = Guid.TryParse(vid, out Guid valueSetVersionGuid);
            if (isVidValidGuid)
            {
                valueSetVersionFromRepo = _valueSetVersionRepository.GetValueSetVersion(valueSetVersionGuid);
            }
            else
            {
                ValueSetVersionPaginationParameters parameters = new ValueSetVersionPaginationParameters()
                {
                    ValueSetCode = valueSetFromRepo.ValueSetCode,
                    ValueSetOid = valueSetFromRepo.ValueSetOID,
                };
                var valueSetVersionsFromRepo = _valueSetVersionRepository.GetValueSetVersions(parameters);

                if (vid.Equals("latest", StringComparison.OrdinalIgnoreCase))
                {
                    valueSetVersionFromRepo = valueSetVersionsFromRepo.OrderBy(v => v.ValueSetVersionNumber).LastOrDefault();
                }
                else
                {
                    bool success = int.TryParse(vid, out int vidInt);
                    if (success)
                    {
                        valueSetVersionFromRepo = valueSetVersionsFromRepo.FirstOrDefault(v => v.ValueSetVersionNumber == vidInt);
                    }
                    else
                    {
                        throw new InvalidOperationException("vid must be a valid UUID, integer, or the string literal 'latest'");
                    }
                }
            }

            return (valueSetFromRepo, valueSetVersionFromRepo);
        }

        private ValueSet BuildValueSet(Entities.ValueSetVersion valueSetVersionFromRepo, Entities.ValueSet valueSetFromRepo, bool includeConcepts = true)
        {
            var valueSet = new Hl7.Fhir.Model.ValueSet();
            valueSet.Url = Url.Link(
                nameof(GetVersionedValueSetById), 
                new 
                { 
                    type = "ValueSet", 
                    id = valueSetFromRepo.ValueSetCode, 
                    vid = valueSetVersionFromRepo.ValueSetVersionNumber.ToString() 
                });
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
            valueSet.Name = valueSetFromRepo.ValueSetCode;
            valueSet.Title = valueSetFromRepo.ValueSetName;
            valueSet.Description = new Markdown(valueSetFromRepo.DefinitionText);
            valueSet.Publisher = "PHIN_VADS";
            valueSet.DateElement = new FhirDateTime(valueSetVersionFromRepo.StatusDate);
            valueSet.Version = valueSetVersionFromRepo.ValueSetVersionNumber.ToString();
            valueSet.VersionId = valueSetVersionFromRepo.ValueSetVersionID.ToString();
            valueSet.Status = PublicationStatus.Active;

            if (includeConcepts)
            {
                valueSet.Expansion = new ValueSet.ExpansionComponent()
                {
                    Identifier = Guid.NewGuid().ToString(),
                    TimestampElement = new FhirDateTime(DateTimeOffset.Now),
                    Contains = new List<ValueSet.ContainsComponent>()
                };

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
                valueSet.Expansion.Offset = (paginationParameters.PageNumber - 1) * paginationParameters.PageSize;
            }

            return valueSet;
        }
        #endregion // Private methods
    }
}