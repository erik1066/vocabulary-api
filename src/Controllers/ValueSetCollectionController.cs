using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.WebApi.Helpers;
using Swashbuckle.AspNetCore.Annotations;
using Cdc.Vocabulary.Services;
using AutoMapper;
using Cdc.Vocabulary.Entities;

namespace Cdc.Vocabulary.WebApi.Controllers
{
    /// <summary>
    /// Value set controller class
    /// </summary>
    [ApiController]
    [Route("api/1.0/valuesetcollection")]
    public class ValueSetCollectionController : ControllerBase
    {
        private readonly ILogger<ValueSetCollectionController> _logger;
        private readonly IValueSetRepository _valueSetRepository;

        public ValueSetCollectionController(ILogger<ValueSetCollectionController> logger, IValueSetRepository valueSetRepository)
        {
            _logger = logger;
            _valueSetRepository = valueSetRepository;
        }

        // GET api/1.0/valuesetcollection/cdc
        /// <summary>
        /// Gets a collection of value sets
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="paginationParameters">Optional pagination parameters</param>
        /// <returns>ValueSets</returns>
        [HttpGet("{domain}", Name = "GetValueSets")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns ValueSets", typeof(IEnumerable<ValueSetForRetrievalDto>))]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(404, "Not found", null)]
        [SwaggerResponse(500)]
        public ActionResult<IEnumerable<ValueSetForRetrievalDto>> GetValueSets(
            [FromRoute] DomainRouteParameters routeParameters,
            [FromQuery] PaginationParameters paginationParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Get the items from the database
            var valueSetEntities = _valueSetRepository.GetValueSets(paginationParameters);

            // Get pagination metadata
            var previousPageLink = CreateValueSetResourceUri(routeParameters, paginationParameters, ResourceUriType.PreviousPage);
            var nextPageLink = CreateValueSetResourceUri(routeParameters, paginationParameters, ResourceUriType.NextPage);

            var paginationMetadata = new
            {
                totalCount = valueSetEntities.TotalCount,
                pageSize = valueSetEntities.PageSize,
                currentPage = valueSetEntities.CurrentPage,
                totalPages = valueSetEntities.TotalPages,
                previousPageLink = valueSetEntities.HasPrevious ? previousPageLink : string.Empty,
                nextPageLink = valueSetEntities.HasNext ? nextPageLink : string.Empty
            };

            Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationMetadata));

            var valueSetsToReturn = Mapper.Map<IEnumerable<ValueSetForRetrievalDto>>(valueSetEntities);
            return Ok(valueSetsToReturn);
        }

        // POST api/1.0/valuesetcollection/cdc
        /// <summary>
        /// Inserts a collection of value sets
        /// </summary>
        /// <remarks>
        /// Sample request to insert a collection of value sets:
        ///
        ///     POST /api/1.0/valuesetcollection/cdc
        ///     {
        ///         "code": "PHVS_YesNoUnknown_CDC",
        ///         "definition": "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
        ///         "name": "Yes No Unknown (YNU)",
        ///         "oid": "2.16.840.1.114222.4.11.888"
        ///     }
        ///
        /// </remarks>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="valueSetCollection">The value sets to insert</param>
        [HttpPost("{domain}")]
        [Consumes("application/json")]
        [SwaggerResponse(201, "ValueSets were created successfully")]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(406, "Invalid content type")]
        [SwaggerResponse(413, "The request payload is too large")]
        [SwaggerResponse(415, "Invalid media type")]
        [SwaggerResponse(500)]
        public IActionResult Insert(
            [FromRoute] DomainRouteParameters routeParameters,
            [FromBody] IEnumerable<ValueSetForInsertionDto> valueSetCollection)
        {
            if (valueSetCollection == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Map each item from the request body to a DB entity
            var valueSetEntities = Mapper.Map<IEnumerable<ValueSet>>(valueSetCollection);

            // For each entity, add to context
            foreach (var valueSetEntity in valueSetEntities)
            {
                _valueSetRepository.AddValueSet(valueSetEntity);
            }

            // If save fails on any insert, throw an exception (which will result in a 500, which is correct in this case)
            if (!_valueSetRepository.Save())
            {
                throw new Exception("Creating a value set collection failed on save.");
            }

            // Make sure to collect IDs...
            var valueSetCollectionToReturn = Mapper.Map<IEnumerable<ValueSetForRetrievalDto>>(valueSetEntities);
            var idsAsString = string.Join(",",
                valueSetCollectionToReturn.Select(a => a.Id));

            return CreatedAtAction
            (
                nameof(Get),
                new
                {
                    domain = routeParameters.Domain,
                    ids = idsAsString
                },
                null
            );
        }

        // GET api/1.0/valuesetcollection/cdc/(3a23284c-1e0c-4693-9d15-615060065d0e,40d660e2-6061-496f-a28d-5a4dc42fbf8d)
        /// <summary>
        /// Gets a collection of value sets
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="ids">The IDs of the value sets to retrieve</param>
        /// <returns>ValueSets</returns>
        [HttpGet("{domain}/({ids})")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns a ValueSet collection", typeof(IEnumerable<ValueSetForRetrievalDto>))]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(404, "One or more of the value sets were not found", null)]
        [SwaggerResponse(500)]
        public IActionResult Get(
            [FromRoute] DomainRouteParameters routeParameters,
            [FromRoute] [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<string> ids)
        {
            if (ids == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var guids = new List<Guid>(ids.Count());

            foreach (var id in ids)
            {
                guids.Add(new Guid(id)); // TODO: Fix this so we can model bind to GUIDs, or perhaps just try to parse as a GUID and return a 400 if it isn't a valid GUID. If the former, note the ArrayModelBinder doesn't support that at the moment... should look into a fix.
            }

            var valueSetEntities = _valueSetRepository.GetValueSets(guids);

            if (ids.Count() != valueSetEntities.Count())
            {
                return NotFound(); // even one ID that isn't found should generate a 404
            }

            var valueSetsToReturn = Mapper.Map<IEnumerable<ValueSetForRetrievalDto>>(valueSetEntities);
            return Ok(valueSetsToReturn);
        }

        private string CreateValueSetResourceUri(DomainRouteParameters domainParameters, PaginationParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link(nameof(GetValueSets),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber - 1,
                        pageSize = parameters.PageSize
                    });
                case ResourceUriType.NextPage:
                    return Url.Link(nameof(GetValueSets),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber + 1,
                        pageSize = parameters.PageSize
                    });
                default:
                    return Url.Link(nameof(GetValueSets),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber,
                        pageSize = parameters.PageSize
                    });
            }
        }
    }
}
