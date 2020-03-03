using ContractApi.Business.Implementations;
using ContractApi.HyperMedia;
using ContractApi.Models.Context;
using ContractApi.Repository.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tapioca.HATEOAS;

namespace ContractApi
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
            services.AddMvc();

            services.AddApiVersioning();
           // string connection = "Data Source=DEV-NET\\SQLEXPRESS;Initial Catalog=WebApiCliente;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<BaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexao")));
            
            //hATEOAS
            var filterOptions = new HyperMediaFilterOptions();
            filterOptions.ObjectContentResponseEnricherList.Add(new ContractEnricher());
            filterOptions.ObjectContentResponseEnricherList.Add(new EmpresaEnricher());

            services.AddSingleton(filterOptions);

            //sWAGGER


            services.AddSwaggerGen(c => c.SwaggerDoc("v1.0", new Microsoft.OpenApi.Models.OpenApiInfo{ Title = "ContractAPI with ASP.NET Core 2.0" ,Version = "v1.0"}));

            //Adiciona serviços
            services.AddScoped<IEmpresaBusiness, EmpresaBusiness>();
            services.AddScoped<IContratoBusiness, ContratoBusiness>();
            services.AddScoped(typeof(IRepository<>), (typeof(GenericRepository<>)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {

                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "My API V1.0");
            });

            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");

            app.UseRewriter(option);

            app.UseMvc(routes => {

                routes.MapRoute(

                    name: "Defaut",
                    template: "{controller=values}/{id?}"
                    );


            });
        }
    }
}
