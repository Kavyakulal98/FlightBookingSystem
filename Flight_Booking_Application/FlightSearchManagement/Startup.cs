using FlightSearchManagement.Repository;
using ManageAirliness.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightSearchManagement
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
            services.AddDbContextPool<AppDBContext>(
                 options => options.UseSqlServer(Configuration.GetConnectionString("AirlineDBConnection")));
            services.AddMvc();
            // services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            services.AddScoped<IFlightSearchRepository, SQLFlightSearchRepository>();
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseMvcWithDefaultRoute();
            app.Run(async (context) =>
            {

                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
