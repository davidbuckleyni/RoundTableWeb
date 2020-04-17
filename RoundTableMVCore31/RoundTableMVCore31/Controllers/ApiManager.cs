using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoundTableMVCore31.Controllers {
    public class ApiManager : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
