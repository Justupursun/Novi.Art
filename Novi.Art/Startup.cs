using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Novi.Art
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // Middleware:
        // This pipeline processes the requests and responses
        // This method gets called by the runtime. 
        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // HostEnvironmentEnvExtensions.IsDevelopment: Checks if the current host environment name is Microsoft.Extensions.Hosting.EnvironmentName.Development.
            // HostEnvironmentEnvExtensions.IsProduction: Checks if the current host environment name is Microsoft.Extensions.Hosting.EnvironmentName.Production.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ////IApplicationBuilder.Use: Adds a middleware delegate to the application's request pipeline.
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from first Middleware");
            //    await next(); // Steps to the next middleware compnent
            //    await context.Response.WriteAsync("Hello from first Middleware response");
            //});

            ////IApplicationBuilder.Use: Adds a middleware delegate to the application's request pipeline.
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from second Middleware");
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //     EndpointRouteBuilderExtensions.MapGet
                //     Adds a Microsoft.AspNetCore.Routing.RouteEndpoint to the Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
                //     that matches HTTP GET requests for the specified pattern.
                //     EndpointRouteBuilderExtensions.Map:
                //     Adds a Microsoft.AspNetCore.Routing.RouteEndpoint to the Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
                //     that matches HTTP requests for the specified pattern.

                endpoints.Map("/", async context =>
                {
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Hello from Development"); // IHostEnvironment.ApplicationName
                                                                                     // Gets or sets the name of the environment. The host automatically sets this property
                                                                                     // to the value of the of the "environment" key as specified in configuration.
                    } 
                    else if (env.IsProduction())
                    {
                        await context.Response.WriteAsync("Hello from Production");
                    }
                    else if (env.IsStaging())
                    {
                        await context.Response.WriteAsync("Hello from Stage");
                    }
                    else
                    {
                        await context.Response.WriteAsync(env.EnvironmentName);
                    }
                });
            });
        }
    }
}
