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
using UserFlightBooking.Repository;

namespace UserFlightBooking
{
    public class Startup
    {
        private IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddDbContextPool<FlightBookAppDBContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("AirlineDBConnection")));
            services.AddMvc();
            // services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            services.AddScoped<IFlightBookingRepository, SQLFlightBookingRepository>();
           
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
            //app.UseStaticFiles();
            //app.UseCookiePolicy();
            app.Run(async (context) =>
            {

                await context.Response.WriteAsync("Hello World!");
            });
            //app.UseMvc();
        }
    
}
}
