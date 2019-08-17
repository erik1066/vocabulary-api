using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.WebApi.Controllers
{
    [ApiController]
    [Route("api/1.0/valueset")]
    public class ValueSetController : ControllerBase
    {
        private readonly ILogger<ValueSetController> _logger;

        public ValueSetController(ILogger<ValueSetController> logger)
        {
            _logger = logger;
        }

        // GET api/1.0/valueset/PHVS_YesNoUnknown_CDC
        /// <summary>
        /// Gets a value set by its code
        /// </summary>
        /// <returns>ValueSet</returns>
        [HttpGet("{code}")]
        [Produces("application/json")]
        public ActionResult<ValueSetForRetrievalDto> GetByCode([FromRoute] string code)
        {
            var vs = new ValueSetForRetrievalDto();
            vs.Code = code;

            return Ok(vs);
        }
    }
}
