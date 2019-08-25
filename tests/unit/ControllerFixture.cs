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
using Microsoft.AspNetCore.Http;

namespace Cdc.Vocabulary.Tests
{
    public class ControllerFixture : IDisposable
    {
        public ILogger<ValueSetController> ValueSetControllerLogger { get; private set; }
        public ILogger<ValueSetCollectionController> ValueSetCollectionControllerLogger { get; private set; }
        public IValueSetRepository ValueSetRepository { get; private set; }
        public IUrlHelper UrlHelper { get; private set; }
        public HttpResponse Response { get; private set; }

        public ControllerFixture()
        {
            ValueSetControllerLogger = new Mock<ILogger<ValueSetController>>().Object;
            ValueSetCollectionControllerLogger = new Mock<ILogger<ValueSetCollectionController>>().Object;

            Mock<IUrlHelper> urlHelper = new Mock<IUrlHelper>();
            urlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost");
            UrlHelper = urlHelper.Object;

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
                                .UseInMemoryDatabase(databaseName: "vocabulary1")
                                .Options;

            var context = new VocabularyContext(dbOptions);

            context.EnsureSeedDataForContext();

            return new ValueSetRepository(context);
        }
    }
}