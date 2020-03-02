using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractApi.Business.Implementations;
using ContractApi.HyperMedia;
using ContractApi.Models.Context;
using ContractApi.Repository.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
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
            
            var filterOptions = new HyperMediaFilterOptions();
            filterOptions.ObjectContentResponseEnricherList.Add(new ContratoEnricher());
            filterOptions.ObjectContentResponseEnricherList.Add(new EmpresaEnricher());

            services.AddSingleton(filterOptions); 




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

            app.UseMvc(routes => {

                routes.MapRoute(

                    name: "Defaut",
                    template: "{controller=values}/{id?}"
                    );


            });
        }
    }
}
