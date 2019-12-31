using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Http;
 
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization; using Newtonsoft.Json;
using RoundTableAPILib;
using RoundTableERPDal;
using RoundTableERPDal.Models;
using RoundTableWeb.Erp;
 using System.Linq;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.CodeAnalysis;

namespace RoundTableERP.Controllers
{

    public class StockController : Controller
    {

        private readonly IStringLocalizer<StockController> _localizer;

        RoundTableAPIClient apiClient = new RoundTableAPIClient();

        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions {Expires = DateTimeOffset.UtcNow.AddYears(1)}
            );

            return LocalRedirect(returnUrl);
        }


        public StockController(IStringLocalizer<StockController> localizer)
        {
            _localizer = localizer;


        }

        public IActionResult Index()
        {
            var testCulture = CultureInfo.CurrentCulture.Name;

            var TEST = LocalizableResourceString.ViewBag.Title = testCulture;


            return View();
        }


        // GET
        public IActionResult ReadData()
        {
            return View();
        }


        // GET: SalesOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


        public async Task<IActionResult> ReadStock([DataSourceRequest] DataSourceRequest request)
        {
            List<Stock> _result = new List<Stock>();
            _result = await apiClient.GetStockFromApi();
            return Json(_result.ToDataSourceResult(request));
        }


        [AcceptVerbs("Post")]
        public async Task<ActionResult> Stock_Update([DataSourceRequest] DataSourceRequest request, Stock stockItem)
        {
            if (stockItem != null && ModelState.IsValid)
            {
                int x = await apiClient.PostUpdateStock(stockItem);
            }

            return Json(new[] {stockItem}.ToDataSourceResult(request, ModelState));
        }

        // POST: SalesOrder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



    }

}