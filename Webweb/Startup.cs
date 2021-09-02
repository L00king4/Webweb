using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebEntities;
using WebEntities.Models;
using Microsoft.EntityFrameworkCore;
using Webweb.Models.Mappers.Profiles;
using Webweb.DB;
using Webweb.Services.UnitsOfWork;
using Webweb.Services.Interfaces;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.AspNetCore.Localization;
using Webweb.Services.Interfaces.Units;
using System;

namespace Webweb
{
    public class Startup
    {
        readonly string _localhostReactCORS = "__localhost_react";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    name: _localhostReactCORS,
                    builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .WithExposedHeaders("content-disposition")
            .AllowAnyHeader()
            .SetPreflightMaxAge(TimeSpan.FromSeconds(3600)));
                //{
                //    builder.WithOrigins("http://localhost:3000",
                //                        "http://192.168.0.105:3000"
                //                        ).AllowAnyMethod();
                //});
            });
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en-US");
            });
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(Configuration["db:dev2"])
            );
            services.AddControllers();
            services.AddAutoMapper(typeof(DefaultProfile));
            services.AddTransient<IUnitOfCompetition, UnitOfCompetition>();
            services.AddTransient<IUnitOfPayedEvent, UnitOfPayedEvent>();
            services.AddTransient<IUnitOfTraining, UnitOfTraining>();
            services.AddTransient<IUnitOfTrainee, UnitOfTrainee>();
            services.AddTransient<IAllUnitsOfWork, AllUnitsOfWork>();
            if (Configuration["react"].Equals("yes"))
            {
                services.AddSpaStaticFiles(configuration =>
                {
                    configuration.RootPath = "reacty/build";
                });
            }
            //services.AddTransient<DBServiceDapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            if (Configuration["react"].Equals("yes"))
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseCors(_localhostReactCORS);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            if (Configuration["react"].Equals("yes"))
            {
                app.UseSpa(spa =>
                {
                    spa.Options.SourcePath = "reacty";

                    if (env.IsDevelopment())
                    {
                        spa.UseReactDevelopmentServer(npmScript: "start");
                    }
                });
            };
        }
    }
}
