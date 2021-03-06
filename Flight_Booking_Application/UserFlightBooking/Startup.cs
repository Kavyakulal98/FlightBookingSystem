
using BaselineTypeDiscovery;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
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
                options => options.UseLazyLoadingProxies().UseSqlServer(Configuration.GetConnectionString("AirlineDBConnection")));
            services.AddMvc();
            // services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
            services.AddScoped<IFlightBookingRepository, SQLFlightBookingRepository>();
            services.AddCors();
            //CustomAssemblyLoadContext context = new CustomAssemblyLoadContext();
            //context.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"));
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            //var context = new CustomAssemblyLoadContext();
            //context.LoadUnmanagedLibrary(Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll"););
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(Options => Options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
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
