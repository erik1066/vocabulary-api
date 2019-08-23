using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Cdc.Vocabulary.Entities;
using Cdc.Vocabulary.Services;
using AutoMapper;
using Cdc.Vocabulary.WebApi.Models;

namespace Cdc.Vocabulary.WebApi
{
    public class Startup
    {
        private const string API_NAME = "Vocabulary API";
        private const string API_VERSION = "v1";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = API_NAME,
                    Version = API_VERSION,
                    Description = "The vocabulary API provides standard vocabularies in one place. It can be used as part of a web-based enterprise vocabulary system for accessing, searching and distributing vocabularies used in public health and clinical care practice.",
                    Contact = new OpenApiContact
                    {
                        Name = "Erik Knudsen",
                        Email = string.Empty,
                        Url = new Uri("https://github.com/erik1066")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Apache 2.0",
                        Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddDbContext<ValueSetContext>(o => o.UseInMemoryDatabase("vocabulary"));

            // register the repository
            services.AddScoped<IValueSetRepository, ValueSetRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ValueSetContext valueSetContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseDefaultFiles(); // will ensure index.html is returned when no resource is specified; this must come before the UseStaticFiles() line below
            app.UseStaticFiles(); // needed for the wwwroot folder so we can serve index.html

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{API_NAME} {API_VERSION}");
            });

            app.UseRouting();

            app.UseAuthorization();

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

                cfg.CreateMap<ValueSetForInsertionDto, ValueSet>()
                    .ForMember(dest => dest.DefinitionText, opt => opt.MapFrom(src =>
                        src.Definition))
                    .ForMember(dest => dest.ValueSetCode, opt => opt.MapFrom(src =>
                        src.Code))
                    .ForMember(dest => dest.ValueSetName, opt => opt.MapFrom(src =>
                        src.Name))
                    .ForMember(dest => dest.ValueSetOID, opt => opt.MapFrom(src =>
                        src.Oid));
            });

            valueSetContext.EnsureSeedDataForContext();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
