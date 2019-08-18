using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;
using Moq;
using Cdc.Vocabulary.WebApi.Controllers;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.Tests
{
    public class ValueSetControllerTests : IClassFixture<ValueSetControllerFixture>
    {
        ValueSetControllerFixture _fixture;

        public ValueSetControllerTests(ValueSetControllerFixture fixture)
        {
            this._fixture = fixture;
        }

        // [Theory]
        // [InlineData("cdc", "3a23284c-1e0c-4693-9d15-615060065d0e")]
        // public void Get_ValueSet(string domain, string id)
        // {
        //     // Arrange
        //     var controller = new ValueSetController(_fixture.Logger);

        //     // Act
        //     var getResult = controller.Get(new ValueSetRouteParameters() { Domain = domain, Id = id });

        //     ActionResult<ValueSetForRetrievalDto> okResult = ((ActionResult<ValueSetForRetrievalDto>)getResult);
        //     OkObjectResult result = (OkObjectResult)okResult.Result;

        //     // Assert
        //     Assert.Equal(200, result.StatusCode);
        // }
    }

    public class ValueSetControllerFixture : IDisposable
    {
        public ILogger<ValueSetController> Logger { get; private set; }

        public ValueSetControllerFixture()
        {
            Logger = new Mock<ILogger<ValueSetController>>().Object;
        }

        public void Dispose()
        {
        }
    }
}
