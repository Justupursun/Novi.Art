using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace Novi.Art
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // ConfigureServices: Add all the dependencies
        public void ConfigureServices(IServiceCollection services)
        {
            // 1 services.AddControllers();
            // 2 services.AddMvc();
            // 3 services.AddRazorPages();
            // 4 services.AddControllersWithViews();
            services.AddControllersWithViews(); // Use controllers and views in our application
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
        }
            // Middleware:
            // This pipeline processes the requests and responses
            // This method gets called by the runtime. 
            // Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            // If you want to use static files from outside the wwwroot-folder
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),
            //     "MyStaticfolesFolder")), RequestPath = "MyStaticfolesFolder"
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // ControllerEndpointRouteBuilderExtensions.MapDefaultControllerRoute():
                // Adds endpoints for controller actions to the Microsoft.AspNetCore.Routing.IEndpointRouteBuilder
                // and adds the default route {controller=Home}/{action=Index}/{id?}.

                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
