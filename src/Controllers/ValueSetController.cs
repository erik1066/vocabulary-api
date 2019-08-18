using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cdc.Vocabulary.WebApi.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Cdc.Vocabulary.WebApi.Controllers
{
    /// <summary>
    /// Value set controller class
    /// </summary>
    [ApiController]
    [Route("api/1.0/valueset")]
    public class ValueSetController : ControllerBase
    {
        private readonly ILogger<ValueSetController> _logger;

        public ValueSetController(ILogger<ValueSetController> logger)
        {
            _logger = logger;
        }

        // GET api/1.0/valueset/cdc/PHVS_YesNoUnknown_CDC
        /// <summary>
        /// Gets a value set
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <returns>ValueSet</returns>
        [HttpGet("{domain}/{id}")]
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

            // TODO: Get the item from the database

            var valueSet = new ValueSetForRetrievalDto()
            {
                Code = "PHVS_YesNoUnknown_CDC",
                Name = "Yes No Unknown (YNU)",
                Oid = "2.16.840.1.114222.4.11.888",
                Definition = "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
                CreatedDate = new DateTime(2007, 03, 20),
                LastRevisionDate = new DateTime(2007, 03, 20),
                Id = Guid.NewGuid(),
                StatusDate = new DateTime(2007, 03, 20)
            };

            return Ok(valueSet);
        }

        // POST api/1.0/valueset/cdc
        /// <summary>
        /// Inserts a value set
        /// </summary>
        /// <remarks>
        /// Sample request to insert a value set:
        ///
        ///     POST /api/1.0/valueset/cdc
        ///     {
        ///         "code": "PHVS_YesNoUnknown_CDC",
        ///         "definition": "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
        ///         "name": "Yes No Unknown (YNU)",
        ///         "oid": "2.16.840.1.114222.4.11.888"
        ///     }
        ///
        /// </remarks>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="valueSet">The value set to insert</param>
        [HttpPost("{domain}")]
        [Consumes("application/json")]
        [SwaggerResponse(201, "ValueSet was created successfully")]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(406, "Invalid content type")]
        [SwaggerResponse(413, "The request payload is too large")]
        [SwaggerResponse(415, "Invalid media type")]
        [SwaggerResponse(500)]
        public IActionResult Insert([FromRoute] DomainRouteParameters routeParameters, [FromBody] ValueSetForInsertionDto valueSet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Insert and get the ID

            return CreatedAtAction
            (
                nameof(Get),
                new
                {
                    domain = routeParameters.Domain,
                    id = "3a23284c-1e0c-4693-9d15-615060065d0e" // TODO: Replace hard-coded GUID
                },
                null
            );
        }

        // PUT api/1.0/valueset/cdc/3a23284c-1e0c-4693-9d15-615060065d0e
        /// <summary>
        /// Replaces a value set
        /// </summary>
        /// <remarks>
        /// Sample request to replace a value set:
        ///
        ///     PUT /api/1.0/valueset/cdc/3a23284c-1e0c-4693-9d15-615060065d0e
        ///     {
        ///         "code": "PHVS_YesNoUnknown_CDC",
        ///         "definition": "Value set used to respond to any question that can be answered Yes, No, or Unknown.",
        ///         "name": "Yes No Unknown (YNU)",
        ///         "oid": "2.16.840.1.114222.4.11.888"
        ///     }
        ///
        /// </remarks>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="valueSet">The value set to insert</param>
        [HttpPut("{domain}/{id}")]
        [Consumes("application/json")]
        [SwaggerResponse(204, "ValueSet was replaced successfully")]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(406, "Invalid content type")]
        [SwaggerResponse(413, "The request payload is too large")]
        [SwaggerResponse(415, "Invalid media type")]
        [SwaggerResponse(500)]
        public IActionResult Replace([FromRoute] ValueSetRouteParameters routeParameters, [FromBody] ValueSetForInsertionDto valueSet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Replace the item

            return NoContent();
        }

        // DELETE api/1.0/valueset/cdc/3a23284c-1e0c-4693-9d15-615060065d0e
        /// <summary>
        /// Deletes a value set
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        [HttpDelete("{domain}/{id}")]
        [SwaggerResponse(204, "ValueSet was deleted successfully")]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(500)]
        public IActionResult Delete([FromRoute] ValueSetRouteParameters routeParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Delete the item

            return NoContent();
        }

        #region Helper methods

        /// <summary>
        /// Checks to see whether a string can be converted into a GUID
        /// </summary>
        /// <param name="guidToTest">The string to check</param>
        /// <returns>Whether the string is a valid GUID</returns>
        private bool IsGuid(string guidToTest) => Guid.TryParse(guidToTest, out var _);

        /// <summary>
        /// Checks to see whether a string can be converted into an OID
        /// </summary>
        /// <remarks>
        /// An example of a valid OID looks like this: 2.16.840.1.114222.4.11.888
        /// </remarks>
        /// <param name="oidToTest">The string to check</param>
        /// <returns>Whether the string is a valid OID</returns>
        private bool IsOid(string oidToTest)
        {
            string[] parts = oidToTest.Split(".");

            // OIDs for our purposes will always have >5 parts
            if (parts.Length >= 5)
            {
                return false;
            }

            // iterate over each part and make sure the part is a valid integer
            foreach (var part in parts)
            {
                bool isNumber = int.TryParse(part, out var _);
                if (!isNumber)
                {
                    // any invalid integer fails the check
                    return false;
                }
            }

            return true;
        }

        #endregion // Helper methods
    }
}
