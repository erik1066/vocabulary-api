using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.WebApi.Helpers;
using Swashbuckle.AspNetCore.Annotations;

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

        public ValueSetCollectionController(ILogger<ValueSetCollectionController> logger)
        {
            _logger = logger;
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
        public IActionResult Insert([FromRoute] DomainRouteParameters routeParameters, [FromBody] IEnumerable<ValueSetForInsertionDto> valueSetCollection)
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

            // For each entity, insert into the database

            // If save fails on any insert, throw an exception (which will result in a 500, which is correct in this case)

            // Make sure to collect IDs...

            var ids = new List<string>() { "3a23284c-1e0c-4693-9d15-615060065d0e", "40d660e2-6061-496f-a28d-5a4dc42fbf8d" };
            var idsAsString = string.Join(",", ids);

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
            [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                return BadRequest();
            }

            // get entities from the database matching the IDs

            // if the count of items from DB doesn't match count of IDs from the request, then some IDs were not found and we need to return a 404

            // map each entity
            var valueSets = new List<ValueSetForRetrievalDto>();

            // mocked value sets

            valueSets.Add(new ValueSetForRetrievalDto()
            {
                Code = "PHVS_YesNoUnknown_CDC",
                Name = "Yes No Unknown (YNU)",
                Oid = "2.16.840.1.114222.4.11.888",
                Definition = "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
                CreatedDate = new DateTime(2007, 03, 20),
                LastRevisionDate = new DateTime(2007, 03, 20),
                Id = Guid.NewGuid(),
                StatusDate = new DateTime(2007, 03, 20)
            });

            valueSets.Add(new ValueSetForRetrievalDto()
            {
                Code = "PHVS_RaceCategory_CDC",
                Name = "Race Category",
                Oid = "2.16.840.1.114222.4.11.836",
                Definition = "General race category reported by the patient - subject may have more than one",
                CreatedDate = new DateTime(2007, 03, 20),
                LastRevisionDate = new DateTime(2007, 03, 20),
                Id = Guid.NewGuid(),
                StatusDate = new DateTime(2007, 03, 20)
            });

            return Ok(valueSets);
        }
    }
}
