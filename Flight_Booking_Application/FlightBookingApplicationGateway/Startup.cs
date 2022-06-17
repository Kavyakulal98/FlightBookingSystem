using CacheManager.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingApplicationGateway
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder();
            builder.SetBasePath(env.ContentRootPath)
                .AddJsonFile("configuration.json", optional: false, reloadOnChange: true);
            
            Configuration = builder.Build();

        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            Action<ConfigurationBuilderCachePart> setting = (xx) =>
            {
                xx.WithMicrosoftLogging(yy => {
                    yy.AddConsole(LogLevel.Debug);
                }).WithDictionaryHandle();
            };
            services.AddOcelot((IConfigurationRoot)Configuration, setting);
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //       .AddJwtBearer(options =>
            //       {
            //           options.RequireHttpsMetadata = false;
            //           options.SaveToken = true;
            //           options.TokenValidationParameters = new TokenValidationParameters()
            //           {
            //               ValidateIssuer = true,
            //               ValidateAudience = true,
            //               ValidAudience = Configuration["Jwt:Audience"],
            //               ValidIssuer = Configuration["Jwt:Issuer"],
            //               IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            //           };
            //       });
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(Options => Options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            await app.UseOcelot();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
