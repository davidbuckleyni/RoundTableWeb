using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using RoundTableERPDal;
 

namespace RoundTableWeb.Erp
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
       

            services.AddLocalization(options => { options.ResourcesPath = "Resources"; });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                {
                    new CultureInfo("en"),
                    new CultureInfo("de")
                };

                options.DefaultRequestCulture = new RequestCulture(culture: "de", uiCulture: "de");
                options.SupportedUICultures = supportedCultures;
                options.SupportedCultures = supportedCultures;
            });


            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRequestLocalization(app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value);

            app.UseMvcWithDefaultRoute();
        }
  

    private string BuildResponse(IStringLocalizer stringLocalizer, IStringLocalizerFactory stringLocalizerFactory)
        {
            var currentCultureName = CultureInfo.CurrentCulture.EnglishName;
            var currentUICultureName = CultureInfo.CurrentUICulture.EnglishName;

            var sharedStringLocalizer = stringLocalizerFactory.Create("Shared", null);

            return "<html><body>"
                   + $"<h2>{stringLocalizer["Hello"]}!</h2><table border=\"1\" cellpadding=\"5\" style=\"border-collapse:collapse;\">"
                   + $"<tr><td>{stringLocalizer["Current Culture"]}</td><td>{currentCultureName}</td></tr>"
                   + $"<tr><td>{stringLocalizer["Current UI Culture"]}</td><td>{currentUICultureName}</td></tr>"
                   + $"<tr><td>{stringLocalizer["The Current Date"]}</td><td>{DateTime.Now.ToString("D")}</td></tr>"
                   + $"<tr><td>{stringLocalizer["A Formatted Number"]}</td><td>{(1234567.89).ToString("n")}</td></tr>"
                   + $"<tr><td>{stringLocalizer["A Currency Value"]}</td><td>{(42).ToString("C")}</td></tr></table>"
                   + $"<h2>{sharedStringLocalizer["Goodbye"]}</h2>"
                   + "</body></html>";
        }
    }
}
