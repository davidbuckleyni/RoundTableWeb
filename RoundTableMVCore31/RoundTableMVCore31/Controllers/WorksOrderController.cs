﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoundTableAPILib;

namespace RoundTableMVCore31.Controllers
{
    public class WorksOrderController : Controller
    {
        RoundTableAPIClient apiClient = new RoundTableAPIClient();

        public IActionResult Index()
        {
            return View();
        }
    }
}