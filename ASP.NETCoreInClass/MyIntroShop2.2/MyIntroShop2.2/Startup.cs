﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyIntroShop2._2.Main;
using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.MockData;
using MyIntroShop2._2.Main.Repository;

namespace MyIntroShop2._2
{
    public class Startup
    {
        private IConfigurationRoot _dbConf;
        public Startup(IHostingEnvironment ENV)
        {
            _dbConf = new ConfigurationBuilder().SetBasePath(ENV.ContentRootPath).AddJsonFile("settings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(options => options.UseSqlServer(_dbConf.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAllPhones, PhoneRepository>();
            services.AddTransient<IPhoneCategory, PhoneCategoryRepository>();
            services.AddTransient<IAllRam, RamRepository>();
            services.AddTransient<IRamCategory, RamCategoryRepository>();
            services.AddTransient<IAllSsd, SsdRepository>();
            services.AddTransient<ISsdCategory, SsdCategoryRepository>();
            services.AddTransient<IProcesorCategory, ProcesorCategoryRepository>();
            services.AddTransient<IAllProcesors, ProcesorRepository>();
            services.AddTransient<IAllMotherboards, MotherboardRepository>();
            services.AddTransient<IMotherboardsCategory, MotherboardCategoryRepository>();
            services.AddTransient<IAllVideoCards, VideoCardRepository>();
            services.AddTransient<IVideoCardCategory, VideoCardCategoryRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBContent content = scope.ServiceProvider.GetRequiredService<DBContent>();
                DBObjects.Initial(content);
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Phone}/{action=List}/{id?}");
            });

        }
    }
}
