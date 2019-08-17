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
        /// Gets a value set by its code for a given domain
        /// </summary>
        /// <returns>ValueSet</returns>
        [HttpGet("{domain}/{code}")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns a ValueSet", typeof(ValueSetForRetrievalDto))]
        [SwaggerResponse(404, "Not found", null)]
        [SwaggerResponse(400, "The route parameters are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(500)]
        public ActionResult<ValueSetForRetrievalDto> GetByCode([FromRoute] string domain, [FromRoute] string code)
        {
            var vs = new ValueSetForRetrievalDto();
            vs.Code = code;
            vs.CreatedDate = DateTime.Now;
            vs.LastRevisionDate = DateTime.Now;
            vs.Id = Guid.NewGuid();
            vs.StatusDate = DateTime.Now;

            return Ok(vs);
        }

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
    }
}
