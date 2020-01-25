using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace RoundTableMVCore31.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly ILogger<DashBoardController> _logger;
        private readonly IStringLocalizer<DashBoardController> _localizer;
        public IActionResult Index()


        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
           // Culture contains the information of the requested culture
          var culture = rqf.RequestCulture.Culture;

          bool isFound = _localizer["test"].ResourceNotFound;

            var test = _localizer["test"].Value;
            return View();
        }
        public DashBoardController(ILogger<DashBoardController> logger, IStringLocalizer<DashBoardController> localizer)
        {
            _localizer = localizer;
            _logger = logger;
         

        }

        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
     
    }
}