using ApplicationApp.App;
using ApplicationApp.Interfaces;
using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Infraestructure.Repository;
using Infraestructure.Repository.Generics;
using Intera.CasaPopular.Domain.Interfaces.Services;
using Intera.CasaPopular.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using Intera.CasaPopular.Domain.Validations;
using Intera.CasaPopular.Domain.Interfaces.Validacao;

namespace Intera.CasaPopular.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V1.0.0",
                    new OpenApiInfo
                    {
                        Title = "Casa Popular",
                        Version = "V1.0.0",
                    });

                c.CustomSchemaIds(x => x.FullName); //Essa linha deve ser inserida em casos que há classes com mesmo nome em namespaces diferentes

                //Obtendo o diretório e depois o nome do arquivo .xml de comentários
                var applicationBasePath = PlatformServices.Default.Application.ApplicationBasePath;
                var applicationName = PlatformServices.Default.Application.ApplicationName;
                var xmlDocumentPath = Path.Combine(applicationBasePath, $"{applicationName}.xml");

                //Caso exista arquivo então adiciona-lo
                if (File.Exists(xmlDocumentPath))
                {
                    c.IncludeXmlComments(xmlDocumentPath);
                }
            });

            services.AddSingleton(typeof(IGeneric<>), typeof(RepositoryGenerico<>));
            services.AddSingleton<ICriterio, RepositoryCriterio>();
            services.AddSingleton<IFamilia, RepositoryFamilia>();
            services.AddSingleton<IParentesco, RepositoryParentesco>();
            services.AddSingleton<IPessoa, RepositoryPessoa>();

            services.AddSingleton<ICriterioApp, CriterioApp>();
            services.AddSingleton<IFamiliaApp, FamiliaApp>();
            services.AddSingleton<IParentescoApp, ParentescoApp>();
            services.AddSingleton<IPessoaApp, PessoaApp>();

            services.AddSingleton<ICriterioService, CriterioService>();
            services.AddSingleton<IFamiliaService, FamiliaService>();
            services.AddSingleton<IParentescoService, ParentescoService>();
            services.AddSingleton<IPessoaService, PessoaService>();

            services.AddSingleton<IValidacaoRegra, ValidacaoRegra>();
            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("./swagger/V1.0.0/swagger.json", "Casa popular V1");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
