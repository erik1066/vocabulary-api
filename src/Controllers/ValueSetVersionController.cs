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
    /// Value set version controller class
    /// </summary>
    [ApiController]
    [Route("api/valuesetversion")]
    public class ValueSetVersionController : ControllerBase
    {
        private readonly ILogger<ValueSetVersionController> _logger;
        private readonly IValueSetRepository _valueSetRepository;
        private readonly IValueSetVersionRepository _valueSetVersionRepository;
        private readonly IValueSetConceptRepository _valueSetConceptRepository;
        private readonly ICodeSystemRepository _codeSystemRepository;

        public ValueSetVersionController(
            ILogger<ValueSetVersionController> logger,
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

        // GET api/valuesetversion/cdc/5987c62d-410f-df11-80e4-0015173d1785
        /// <summary>
        /// Gets a value set version
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <returns>ValueSetVersion</returns>
        [HttpGet("{domain}/{id}")]
        [HttpHead("{domain}/{id}")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns a ValueSetVersion", typeof(ValueSetVersionForRetrievalDto))]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(404, "Not found", null)]
        [SwaggerResponse(500)]
        [ResponseCache(VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any, Duration = 86_400, NoStore = false)]
        public ActionResult<ValueSetVersionForRetrievalDto> GetValueSetVersion([FromRoute] ValueSetRouteParameters routeParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_valueSetVersionRepository.ValueSetVersionExists(routeParameters.Id))
            {
                return NotFound();
            }

            var valueSetVersionFromRepo = _valueSetVersionRepository.GetValueSetVersion(routeParameters.Id);
            var valueSetVersion = Mapper.Map<ValueSetVersionForRetrievalDto>(valueSetVersionFromRepo);
            return Ok(valueSetVersion);
        }
    }
}
