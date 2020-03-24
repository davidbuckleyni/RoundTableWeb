using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoundTableDal;
using RoundTableERPDal;
using RoundTableDal.Models;

namespace RoundTableWeb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        // POST: api/Stock
        //[HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }
        // PUT: api/Stock/5
        // [HttpPut("{id}")]
        // public async Task<IActionResult> UdpdateStock(RoundTableDal.Models.Stock stockItem)
        // {
        //     int x = await db.UpdateStockItem(stockItem);
        //     if (x == 200)
        //         return StatusCode(StatusCodes.Status200OK);
        //     else
        //     {
        //         return Ok(stockItem);
        //     }
        // }
        // PUT: api/Stock/5
        // [HttpPut("{id}")]
        // public IActionResult Put(RoundTableDal.Models.Stock stockItem)
        // {
        //     bool isAdded = db.AddStockItem(stockItem);
        //     if (!isAdded)
        //         return StatusCode(StatusCodes.Status304NotModified);
        //     else
        //     {
        //         return Ok(stockItem);
        //     }
        // }

        // DELETE: api/ApiWithActions/5
        // [HttpDelete("{id}")]
        // public IActionResult Delete(RoundTableDal.Models.Stock stockItem)
        // {

        //     bool isAdded = db.DeleteStockItem(stockItem);
        //     if (!isAdded)
        //         return StatusCode(StatusCodes.Status304NotModified);
        //     else
        //     {
        //         return Ok(stockItem);
        //     }
        // }
    }
}