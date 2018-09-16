using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using RN.Lux.Business.Abstract;
using RN.Lux.Business.Concrete;
using RN.Lux.DataAccess.Abstract;
using RN.Lux.DataAccess.Concrete.EntityFrameWork;
using RN.Lux.MvcWebUI.Middlewares;

namespace RN.Lux.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            // Dependency  Injection'i yaptığımız yer
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();


            //Session management
            services.AddSession();

            services.AddMvc();
          


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            // İstenilen middleware i istediğin zaman ekliyosunu (loglama gibi)
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);


            //Default rouute ekledim
            app.UseMvcWithDefaultRoute();
        }
    }
}
