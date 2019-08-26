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

namespace Cdc.Vocabulary.WebApi.Controllers
{
    /// <summary>
    /// Value set controller class
    /// </summary>
    [ApiController]
    [Route("api/valuesetversioncollection")]
    public class ValueSetVersionCollectionController : ControllerBase
    {
        private readonly ILogger<ValueSetVersionCollectionController> _logger;
        private readonly IValueSetRepository _valueSetRepository;
        private readonly IValueSetVersionRepository _valueSetVersionRepository;
        private readonly IValueSetConceptRepository _valueSetConceptRepository;
        private readonly ICodeSystemRepository _codeSystemRepository;

        public ValueSetVersionCollectionController(
            ILogger<ValueSetVersionCollectionController> logger,
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

        // GET api/valuesetversioncollection/cdc
        /// <summary>
        /// Gets a collection of value set versions
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="paginationParameters">Optional pagination parameters</param>
        /// <returns>ValueSetVersions</returns>
        [HttpGet("{domain}", Name = "GetValueSetVersions")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns ValueSetVersions", typeof(IEnumerable<ValueSetVersionForRetrievalDto>))]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(404, "Not found", null)]
        [SwaggerResponse(500)]
        public ActionResult<IEnumerable<ValueSetForRetrievalDto>> GetValueSetVersions(
            [FromRoute] DomainRouteParameters routeParameters,
            [FromQuery] ValueSetVersionPaginationParameters paginationParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Get the items from the database
            var valueSetVersionEntities = _valueSetVersionRepository.GetValueSetVersions(paginationParameters);

            // Get pagination metadata
            var previousPageLink = CreateValueSetResourceUri(routeParameters, paginationParameters, ResourceUriType.PreviousPage);
            var nextPageLink = CreateValueSetResourceUri(routeParameters, paginationParameters, ResourceUriType.NextPage);

            var paginationMetadata = new
            {
                totalCount = valueSetVersionEntities.TotalCount,
                pageSize = valueSetVersionEntities.PageSize,
                currentPage = valueSetVersionEntities.CurrentPage,
                totalPages = valueSetVersionEntities.TotalPages,
                previousPageLink = valueSetVersionEntities.HasPrevious ? previousPageLink : string.Empty,
                nextPageLink = valueSetVersionEntities.HasNext ? nextPageLink : string.Empty
            };

            Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationMetadata));

            var valueSetVersionssToReturn = Mapper.Map<IEnumerable<ValueSetVersionForRetrievalDto>>(valueSetVersionEntities);
            return Ok(valueSetVersionssToReturn);
        }

        private string CreateValueSetResourceUri(DomainRouteParameters domainParameters, ValueSetVersionPaginationParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link(nameof(GetValueSetVersions),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        valueSetOid = parameters.ValueSetOid,
                        valueSetCode = parameters.ValueSetCode,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber - 1,
                        pageSize = parameters.PageSize
                    });
                case ResourceUriType.NextPage:
                    return Url.Link(nameof(GetValueSetVersions),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        valueSetOid = parameters.ValueSetOid,
                        valueSetCode = parameters.ValueSetCode,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber + 1,
                        pageSize = parameters.PageSize
                    });
                default:
                    return Url.Link(nameof(GetValueSetVersions),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        valueSetOid = parameters.ValueSetOid,
                        valueSetCode = parameters.ValueSetCode,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber,
                        pageSize = parameters.PageSize
                    });
            }
        }
    }
}
