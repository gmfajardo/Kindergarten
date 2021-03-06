﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KindergartenAppService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KindergartenAppService
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<kindergartenContext>(option => option.UseInMemoryDatabase(databaseName:"Kidergaeter-control"));
            services.AddDbContext<KindergarterContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DeployConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options=>
            {
                //options.Password.RequiredLength = 10;
                //options.Password.RequiredUniqueChars = 3;
            }).AddEntityFrameworkStores<KindergarterContext>();

            services.AddMvc(
                config =>
                {
                    //This is for allowing to use authorization at action level when there is a authorization at controller level
                    //var policy = new AuthorizationPolicyBuilder()
                    //                    .RequireAuthenticatedUser()
                    //                    .Build();
                    //config.Filters.Add(new AuthorizeFilter(policy));
                }
                
                ).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCors(options =>
               options.AddPolicy("AllowAll", builder =>
               builder
                      //.WithOrigins("http://localhost:4200")
                      //       .WithOrigins("http://localhost:4100")
                      .AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader()
                      //.AllowCredentials()
                      )
               );

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseCors("AllowAll");
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
