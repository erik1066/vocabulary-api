using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using Moq;
using Cdc.Vocabulary.WebApi.Controllers;
using Cdc.Vocabulary.WebApi.Models;
using Cdc.Vocabulary.Services;
using Microsoft.EntityFrameworkCore;
using Cdc.Vocabulary.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cdc.Vocabulary.Tests
{
    public class ValueSetCollectionControllerTests
    {
        ControllerFixture _fixture = Common.Fixture;

        public ValueSetCollectionControllerTests()
        {
        }

        [Theory]
        [InlineData("cdc", 1, 5, "y", 5)]
        [InlineData("cdc", 1, 5, "4t45yrtgdfrg", 0)]
        [InlineData("cdc", 1, 5, "PHVS_YesNoNotApplicable_NCHS", 1)]
        [InlineData("cdc", 1, 5, "PHVS_YesNoNotApplicable_nchs", 1)]
        [InlineData("cdc", 1, 5, "phvs_yesnonotapplicable_nchs", 1)]
        [InlineData("cdc", 1, 5, "PHVS_YESNONOTAPPLICABLE_NCHS", 1)]
        [InlineData("cdc", 1, 15, "PHVS_LabResult_A", 5)]
        public void Get_ValueSets_Search(string domain, int pageNumber, int pageSize, string query, int expectedPageSize)
        {
            // Arrange
            var controller = new ValueSetCollectionController(_fixture.ValueSetCollectionControllerLogger, _fixture.ValueSetRepository);
            controller.Url = _fixture.UrlHelper;

            // Act
            var getResult = controller.GetValueSets(
                new DomainRouteParameters() { Domain = domain },
                new PaginationParameters() { PageNumber = pageNumber, PageSize = pageSize, SearchQuery = query }
            );

            ActionResult<IEnumerable<ValueSetForRetrievalDto>> okResult = ((ActionResult<IEnumerable<ValueSetForRetrievalDto>>)getResult);
            OkObjectResult result = (OkObjectResult)okResult.Result;
            var valueSets = (IEnumerable<ValueSetForRetrievalDto>)result.Value;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(expectedPageSize, valueSets.Count());
        }
    }
}
