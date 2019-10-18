using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RapiSolver.Repository;
using RapiSolver.Repository.context;
using RapiSolver.Repository.implementation;
using RapiSolver.Service;
using RapiSolver.Service.implementation;

namespace RapiSolver.Api
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
            services.AddEntityFrameworkNpgsql ().AddDbContext<ApplicationDbContext> (opt =>
                opt.UseNpgsql (Configuration.GetConnectionString ("DefaultConnection"))); 

            services.AddTransient<IClienteRepository, ClienteRepository> ();
            services.AddTransient<IClienteService, ClienteService> ();

            services.AddTransient<IRolRepository, RolRepository> ();
            services.AddTransient<IRolService, RolService> ();

            services.AddTransient<IUsuarioRepository, UsuarioRepository> ();
            services.AddTransient<IUsuarioService, UsuarioService> ();

            services.AddTransient<ICustomerRepository, CustomerRepository> ();
            services.AddTransient<ICustomerService, CustomerService> ();

            services.AddTransient<ISupplierRepository, SupplierRepository> ();
            services.AddTransient<ISupplierService, SupplierService> ();

            services.AddTransient<ILocationRepository, LocationRepository> ();
            services.AddTransient<ILocationService, LocationService> ();

            services.AddTransient<IServiceCategoryRepository, ServiceCategoryRepository> ();
            services.AddTransient<IServiceCategoryService, ServiceCategoryService> ();

            services.AddTransient<IServicioRepository, ServicioRepository> ();
            services.AddTransient<IServicioService, ServicioService> ();

            services.AddTransient<IServiceDetailsRepository, ServiceDetailsRepository> ();
            services.AddTransient<IServiceDetailsService, ServiceDetailsService> ();


             services.AddCors (options => {
                options.AddPolicy ("Todos",
                    builder => builder.WithOrigins ("*").WithHeaders ("*").WithMethods ("*"));
            });


            services.AddControllers();


           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors ("Todos");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
            //app.UseHttpsRedirection();
            
        }
    }
}
