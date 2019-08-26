using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.Services;
using AutoMapper;
using Swashbuckle.AspNetCore.Annotations;
using Cdc.Vocabulary.Entities;

namespace Cdc.Vocabulary.WebApi.Controllers
{
    /// <summary>
    /// Value set controller class
    /// </summary>
    [ApiController]
    [Route("api/valueset")]
    public class ValueSetController : ControllerBase
    {
        private readonly ILogger<ValueSetController> _logger;
        private readonly IValueSetRepository _valueSetRepository;

        public ValueSetController(ILogger<ValueSetController> logger, IValueSetRepository valueSetRepository)
        {
            _logger = logger;
            _valueSetRepository = valueSetRepository;
        }

        // GET api/valueset/cdc/PHVS_YesNoUnknown_CDC
        /// <summary>
        /// Gets a value set
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <returns>ValueSet</returns>
        [HttpGet("{domain}/{id}")]
        [HttpHead("{domain}/{id}")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns a ValueSet", typeof(ValueSetForRetrievalDto))]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(404, "Not found", null)]
        [SwaggerResponse(500)]
        public ActionResult<ValueSetForRetrievalDto> Get([FromRoute] ValueSetRouteParameters routeParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_valueSetRepository.ValueSetExists(routeParameters.Id))
            {
                return NotFound();
            }

            var valueSetFromRepo = _valueSetRepository.GetValueSet(routeParameters.Id);
            var valueSet = Mapper.Map<ValueSetForRetrievalDto>(valueSetFromRepo);
            return Ok(valueSet);
        }

        // // POST api/valueset/cdc
        // /// <summary>
        // /// Inserts a value set
        // /// </summary>
        // /// <remarks>
        // /// Sample request to insert a value set:
        // ///
        // ///     POST /api/valueset/cdc
        // ///     {
        // ///         "code": "PHVS_YesNoUnknown_CDC",
        // ///         "definition": "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
        // ///         "name": "Yes No Unknown (YNU)",
        // ///         "oid": "2.16.840.1.114222.4.11.888"
        // ///     }
        // ///
        // /// </remarks>
        // /// <param name="routeParameters">Required route parameters needed for the operation</param>
        // /// <param name="valueSet">The value set to insert</param>
        // [HttpPost("{domain}")]
        // [Consumes("application/json")]
        // [SwaggerResponse(201, "ValueSet was created successfully")]
        // [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        // [SwaggerResponse(406, "Invalid content type")]
        // [SwaggerResponse(413, "The request payload is too large")]
        // [SwaggerResponse(415, "Invalid media type")]
        // [SwaggerResponse(500)]
        // public IActionResult Insert([FromRoute] DomainRouteParameters routeParameters, [FromBody] ValueSetForInsertionDto valueSet)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     var valueSetEntity = Mapper.Map<ValueSet>(valueSet);
        //     _valueSetRepository.AddValueSet(valueSetEntity);

        //     if (!_valueSetRepository.Save())
        //     {
        //         throw new Exception("Creating a value set failed on save.");
        //     }

        //     var valueSetToReturn = Mapper.Map<ValueSetForRetrievalDto>(valueSetEntity);

        //     return CreatedAtAction
        //     (
        //         nameof(Get),
        //         new
        //         {
        //             domain = routeParameters.Domain,
        //             id = valueSetToReturn.Id
        //         },
        //         null
        //     );
        // }

        // // PUT api/valueset/cdc/3a23284c-1e0c-4693-9d15-615060065d0e
        // /// <summary>
        // /// Replaces a value set
        // /// </summary>
        // /// <remarks>
        // /// Sample request to replace a value set:
        // ///
        // ///     PUT /api/valueset/cdc/3a23284c-1e0c-4693-9d15-615060065d0e
        // ///     {
        // ///         "code": "PHVS_YesNoUnknown_CDC",
        // ///         "definition": "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
        // ///         "name": "Yes No Unknown (YNU)",
        // ///         "oid": "2.16.840.1.114222.4.11.888"
        // ///     }
        // ///
        // /// </remarks>
        // /// <param name="routeParameters">Required route parameters needed for the operation</param>
        // /// <param name="valueSet">The value set to insert</param>
        // [HttpPut("{domain}/{id}")]
        // [Consumes("application/json")]
        // [SwaggerResponse(204, "ValueSet was replaced successfully")]
        // [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        // [SwaggerResponse(406, "Invalid content type")]
        // [SwaggerResponse(413, "The request payload is too large")]
        // [SwaggerResponse(415, "Invalid media type")]
        // [SwaggerResponse(500)]
        // public IActionResult Replace([FromRoute] ValueSetRouteParameters routeParameters, [FromBody] ValueSetForInsertionDto valueSet)
        // {
        //     if (valueSet == null)
        //     {
        //         return BadRequest();
        //     }

        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     if (!_valueSetRepository.ValueSetExists(routeParameters.Id))
        //     {
        //         return NotFound();
        //     }

        //     var valueSetFromRepo = _valueSetRepository.GetValueSet(routeParameters.Id);
        //     Mapper.Map(valueSet, valueSetFromRepo);
        //     _valueSetRepository.UpdateValueSet(valueSetFromRepo);

        //     if (!_valueSetRepository.Save())
        //     {
        //         throw new Exception($"Updating value set {routeParameters.Id} failed on save.");
        //     }

        //     return NoContent();
        // }

        // // DELETE api/valueset/cdc/3a23284c-1e0c-4693-9d15-615060065d0e
        // /// <summary>
        // /// Deletes a value set
        // /// </summary>
        // /// <param name="routeParameters">Required route parameters needed for the operation</param>
        // [HttpDelete("{domain}/{id}")]
        // [SwaggerResponse(204, "ValueSet was deleted successfully")]
        // [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        // [SwaggerResponse(500)]
        // public IActionResult Delete([FromRoute] ValueSetRouteParameters routeParameters)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     if (!_valueSetRepository.ValueSetExists(routeParameters.Id))
        //     {
        //         return NotFound();
        //     }

        //     var valueSetFromRepo = _valueSetRepository.GetValueSet(routeParameters.Id);
        //     _valueSetRepository.DeleteValueSet(valueSetFromRepo);

        //     if (!_valueSetRepository.Save())
        //     {
        //         throw new Exception($"Deleting value set {routeParameters.Id} failed on save.");
        //     }

        //     return NoContent();
        // }
    }
}
