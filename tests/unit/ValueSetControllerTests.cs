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

namespace Cdc.Vocabulary.Tests
{
    public class ValueSetControllerTests : IClassFixture<ValueSetControllerFixture>
    {
        ValueSetControllerFixture _fixture;

        public ValueSetControllerTests(ValueSetControllerFixture fixture)
        {
            this._fixture = fixture;
        }

        [Theory]
        [InlineData("cdc", "f9504f32-bf11-df11-80e4-0015173d1785", "PHVS_CountrySubdivision_ISO_3166-2", "Country Subdivision (ISO 3166-2)", "2.16.840.1.114222.4.11.3286", "ISO 3166-2:Codes for the representation of names of countries and their subdivisions - Part 2: Country subdivision code which gives codes for the names of the principal subdivisions (e.g provinces or states) of all countries coded in ISO 3166-1. This code is based on the two-letter code element from ISO 3166-1 followed by a separator and a further string of up to three alphanumeric characters. Keywords: IS0 3166-2 Part 2, Country subdivision, Country Subdivisions, Provinces")]
        [InlineData("cdc", "6783b3a0-607f-dd11-b38d-00188b398520", "PHVS_WoundHistory_CDC", "Wound History", "2.16.840.1.114222.4.11.3115", "Wound History during exposure answer list")]
        [InlineData("cdc", "1448693c-bdc4-de11-913d-0015173d1785", "PHVS_DeathLocation_Flu", "Death Location (Flu)", "2.16.840.1.114222.4.11.3261", "Death Location. Where did the subject die?")]
        [InlineData("cdc", "84bf6ec0-9ac4-de11-913d-0015173d1785", "PHVS_TimeFrameDailyWeekly_CDC", "Time Frame (Daily Weekly)", "2.16.840.1.114222.4.11.3256", "Interval of grouped subjects being reported inside of a repeating group. Keyword: Count Group Interval")]
        // [InlineData("cdc", "REPLACEME", "REPLACEME", "REPLACEME", "REPLACEME", "REPLACEME")]
        public void Get_ValueSet(string domain, string id, string code, string name, string oid, string definition)
        {
            // Arrange
            var guid = new Guid(id);
            var controller = new ValueSetController(_fixture.Logger, _fixture.ValueSetRepository);

            // Act
            var getResult = controller.Get(new ValueSetRouteParameters() { Domain = domain, Id = guid });

            ActionResult<ValueSetForRetrievalDto> okResult = ((ActionResult<ValueSetForRetrievalDto>)getResult);
            OkObjectResult result = (OkObjectResult)okResult.Result;
            var valueSet = (ValueSetForRetrievalDto)result.Value;

            // Assert
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(code, valueSet.Code);
            Assert.Equal(name, valueSet.Name);
            Assert.Equal(oid, valueSet.Oid);
            Assert.Equal(definition, valueSet.Definition);
        }

        [Theory]
        [InlineData("cdc", "f9504f32-bf11-df11-80e4-0015173d1786")]
        [InlineData("cdc", "f9504f32-bf11-df11-80e4-0015173d1784")]
        public void Get_ValueSet_Fail_NotFound(string domain, string id)
        {
            // Arrange
            var guid = new Guid(id);
            var controller = new ValueSetController(_fixture.Logger, _fixture.ValueSetRepository);

            // Act
            var getResult = controller.Get(new ValueSetRouteParameters() { Domain = domain, Id = guid });

            ActionResult<ValueSetForRetrievalDto> okResult = ((ActionResult<ValueSetForRetrievalDto>)getResult);
            NotFoundResult result = (NotFoundResult)okResult.Result;

            // Assert
            Assert.Equal(404, result.StatusCode);
        }
    }

    public class ValueSetControllerFixture : IDisposable
    {
        public ILogger<ValueSetController> Logger { get; private set; }
        public IValueSetRepository ValueSetRepository { get; private set; }

        public ValueSetControllerFixture()
        {
            Logger = new Mock<ILogger<ValueSetController>>().Object;
            ValueSetRepository = CreateSUT();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ValueSet, ValueSetForRetrievalDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src =>
                        src.ValueSetID))
                    .ForMember(dest => dest.Code, opt => opt.MapFrom(src =>
                        src.ValueSetCode))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src =>
                        src.ValueSetName))
                    .ForMember(dest => dest.Oid, opt => opt.MapFrom(src =>
                        src.ValueSetOID))
                    .ForMember(dest => dest.Definition, opt => opt.MapFrom(src =>
                        src.DefinitionText));
            });
        }

        public void Dispose()
        {
        }

        private ValueSetRepository CreateSUT()
        {
            var dbOptions = new DbContextOptionsBuilder<VocabularyContext>()
                                .UseInMemoryDatabase(databaseName: "vocabulary")
                                .Options;

            var context = new VocabularyContext(dbOptions);

            context.EnsureSeedDataForContext();

            return new ValueSetRepository(context);
        }
    }
}
