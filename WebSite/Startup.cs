using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

            services.Configure<RequestLocalizationOptions>(opts =>
            {
                var supportedCultures = new List<CultureInfo> { new CultureInfo("en-GB"), new CultureInfo("fr-FR"), };

                opts.DefaultRequestCulture = new RequestCulture("en-GB");

                // Formatting numbers, dates, etc.
                opts.SupportedCultures = supportedCultures;
                // UI strings that we have localized.
                opts.SupportedUICultures = supportedCultures;
            });
            // Add framework services.
            services.AddControllersWithViews()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                // Maintain property names during serialization. See:
                // https://github.com/aspnet/Announcements/issues/194
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                    opts => { opts.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization();
            services.Configure<ConnectionStringConfig>(Configuration);
            //lets inject the connection string to the data layer 
            //but we should be using the api layer for any heavy lifting.
            services.AddHttpClient("externalservice", c =>
            {
                // Assume this is an "external" service which requires an API KEY
                c.BaseAddress = new Uri("https://localhost:5001/");
            });
        
            // Add Kendo UI services to the services container
                        services.AddKendo();
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

            SetUpLocalization(app);

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
        
            app.UseRequestLocalization(options.Value);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
        private static void SetUpLocalization(IApplicationBuilder app)
        {
            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("en-GB")
            };

            var options = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-GB", "en-GB"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
             
            };
            options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
            {
                // My custom request culture logic
                return new ProviderCultureResult("en");
            }));

            // Find the cookie provider with LINQ
            var cookieProvider = options.RequestCultureProviders
                .OfType<CookieRequestCultureProvider>()
                .First();
            // Set the new cookie name
            cookieProvider.CookieName = "UserCulture";


            // Configure the Localization middleware
            app.UseRequestLocalization(options);




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
