using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoundTableDal;
using Microsoft.AspNetCore.Authentication.JwtBearer;
namespace RoundTableWeb.Api.Controllers
{
    
    [ApiController]

    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/[controller]")]     

    public class StockController : ControllerBase
    {
        RoundTableERPContext db = new RoundTableERPContext();


        // GET: api/Stock
        [HttpGet]
     
        public IEnumerable<RoundTableDal.Models.Stock> Get()
        {
            return db.GetAlLStock();
        }

        // GET: api/Stock/5
        [HttpGet("{id}", Name = "GetStockById")]
        public string GetStockById(int id)
        {
            return "value";
        }

        
    }
}