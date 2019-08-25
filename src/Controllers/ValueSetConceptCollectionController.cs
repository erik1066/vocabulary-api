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
    [Route("api/1.0/valuesetconceptcollection")]
    public class ValueSetConceptCollectionController : ControllerBase
    {
        private readonly ILogger<ValueSetConceptCollectionController> _logger;
        private readonly IValueSetRepository _valueSetRepository;
        private readonly IValueSetVersionRepository _valueSetVersionRepository;
        private readonly IValueSetConceptRepository _valueSetConceptRepository;
        private readonly ICodeSystemRepository _codeSystemRepository;

        public ValueSetConceptCollectionController(
            ILogger<ValueSetConceptCollectionController> logger,
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

        // GET api/1.0/valuesetconceptcollection/cdc
        /// <summary>
        /// Gets a collection of value set concepts
        /// </summary>
        /// <param name="routeParameters">Required route parameters needed for the operation</param>
        /// <param name="paginationParameters">Optional pagination parameters</param>
        /// <returns>ValueSetConcepts</returns>
        [HttpGet("{domain}", Name = "GetValueSetConcepts")]
        [Produces("application/json")]
        [SwaggerResponse(200, "Returns ValueSetConcepts", typeof(IEnumerable<ValueSetConceptForRetrievalDto>))]
        [SwaggerResponse(400, "The provided inputs are invalid", typeof(IDictionary<string, string>))]
        [SwaggerResponse(404, "Not found", null)]
        [SwaggerResponse(500)]
        public ActionResult<IEnumerable<ValueSetForRetrievalDto>> GetValueSetConcepts(
            [FromRoute] DomainRouteParameters routeParameters,
            [FromQuery] ValueSetConceptPaginationParameters paginationParameters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Get the items from the database
            var valueSetConceptEntities = _valueSetConceptRepository.GetValueSetConcepts(paginationParameters);

            // Get pagination metadata
            var previousPageLink = CreateValueSetResourceUri(routeParameters, paginationParameters, ResourceUriType.PreviousPage);
            var nextPageLink = CreateValueSetResourceUri(routeParameters, paginationParameters, ResourceUriType.NextPage);

            var paginationMetadata = new
            {
                totalCount = valueSetConceptEntities.TotalCount,
                pageSize = valueSetConceptEntities.PageSize,
                currentPage = valueSetConceptEntities.CurrentPage,
                totalPages = valueSetConceptEntities.TotalPages,
                previousPageLink = valueSetConceptEntities.HasPrevious ? previousPageLink : string.Empty,
                nextPageLink = valueSetConceptEntities.HasNext ? nextPageLink : string.Empty
            };

            Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationMetadata));

            var valueSetConceptsToReturn = Mapper.Map<IEnumerable<ValueSetConceptForRetrievalDto>>(valueSetConceptEntities);
            return Ok(valueSetConceptsToReturn);
        }

        private string CreateValueSetResourceUri(DomainRouteParameters domainParameters, ValueSetVersionPaginationParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link(nameof(GetValueSetConcepts),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        oid = parameters.Oid,
                        code = parameters.Code,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber - 1,
                        pageSize = parameters.PageSize
                    });
                case ResourceUriType.NextPage:
                    return Url.Link(nameof(GetValueSetConcepts),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        oid = parameters.Oid,
                        code = parameters.Code,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber + 1,
                        pageSize = parameters.PageSize
                    });
                default:
                    return Url.Link(nameof(GetValueSetConcepts),
                    new
                    {
                        searchQuery = parameters.SearchQuery,
                        oid = parameters.Oid,
                        code = parameters.Code,
                        domain = domainParameters.Domain,
                        pageNumber = parameters.PageNumber,
                        pageSize = parameters.PageSize
                    });
            }
        }
    }
}
