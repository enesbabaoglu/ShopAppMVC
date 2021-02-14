using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EFCore;
using shopapp.business.Concrete;
using shopapp.business.Abstract;

namespace shopapp.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //MVC
            //RazorPages
            services.AddScoped<IProductRepository,EfCoreProductRepository>();
            services.AddScoped<IProductService,ProductManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();//wwwroot
            app.UseStaticFiles(new StaticFileOptions{
                FileProvider=new Microsoft.Extensions.FileProviders.PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")
                ),
                RequestPath="/modules"
            });
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //localhost:5000
            //localhost:5000/products
            //localhost:5000/products/list

            app.UseEndpoints(endpoints =>
            {
              endpoints.MapControllerRoute(
                  name: "default",
                  pattern : "{controller=home}/{action=index}/{id?}"
              );
            });
        }
    }
}
