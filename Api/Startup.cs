using Application;
using Application.Interfaces.App;
using Application.Services;
using Domain.Interfaces;
using FluentValidation.AspNetCore;
using Infrastructure.Filter;
using Infrastructure.Persistance;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class Startup
    {
        private readonly string MasiveUIPolicy = "UIPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Se agrega el fluen validation y controladores
            services
                .AddControllers(Option =>
                {
                    Option.Filters.Add<GlobalExceptionFilter>();
                })
                .AddFluentValidation();

            //Se registran las dependencias del proyecto Masive.Application
            services.AddApplicationServices();

            //Enlace de base de datos
            services.AddDbContext<BdmasiveContext>(Options => Options.UseSqlServer(Configuration.GetConnectionString("Bdmasive")));

            //Se registran las dependencias de los Repositorios 
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IFacturaRepository, FacturaRepository>();
            services.AddTransient<IProductoRepository, ProductoRepository>();
            

            //Se registran las dependencias de los servicios
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IFacturaService, FacturaService>();
            services.AddTransient<IProductoService, ProductoService>();


            services.AddCors(options =>
            {
                options.AddPolicy(MasiveUIPolicy,
                builder =>
                {
                    builder.WithOrigins("http://localhost:53135",
                                        "http://localhost:4200"
                                        )
                                        .AllowAnyHeader()
                                        .AllowAnyMethod();
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            //CORS
            app.UseCors(MasiveUIPolicy);

       

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
