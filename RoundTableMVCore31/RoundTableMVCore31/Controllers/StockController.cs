﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;

using System.Linq;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Localization;
using RoundTableAPILib;
using RoundTableDal.Models;
using static RoundTableAPILib.RoundTableAPIClient;

namespace RoundTableERP.Controllers
{
    public class StockController : Controller
    {
        private readonly IStringLocalizer<StockController> _localizer;

        RoundTableAPIClient apiClient;

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
            apiClient = new RoundTableAPIClient("B538F53B-37F7-4564-B7C5-56AFF399252B", "8132ED0B-8F0B-4841-8BF4-CE8438AC0F3E");
 
        }

        public IActionResult Index()
        {
            var testCulture = CultureInfo.CurrentCulture.Name;


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

        [HttpGet]
        public async Task<object> Get(DataSourceLoadOptions loadOptions)
        {
            List<Stock> _result = new List<Stock>();
            apiClient.DeveiceType = device.Desktop;
            apiClient.DeveiceType = device.Desktop;
            apiClient.ApiKey = "B538F53B-37F7-4564-B7C5-56AFF399252B";
            apiClient.ClientSecret = "8132ED0B-8F0B-4841-8BF4-CE8438AC0F3E";
        
            _result =  await apiClient.GetStockFromApi(apiClient.ApiKey,apiClient.ClientSecret);
            return DataSourceLoader.Load(_result, loadOptions);
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
 

            [HttpPut]
        public async  Task<IActionResult> Put(int key, string values )
        {
            apiClient.ApiKey = "B538F53B-37F7-4564-B7C5-56AFF399252B";
            apiClient.ClientSecret = "8132ED0B-8F0B-4841-8BF4-CE8438AC0F3E";

            var stockItem =  apiClient.GetStockFromApi(apiClient.ApiKey, apiClient.ClientSecret).Result.First(s=>s.ID==key);
            JsonConvert.PopulateObject(values, stockItem);

            await apiClient.PostUpdateStock(stockItem);
            return Ok(stockItem);

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