using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoundTableDal;
using RoundTableDal.Models;

namespace RoundTableWeb.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WorksController : ControllerBase
    {
        RoundTableERPContext db = new RoundTableERPContext();

        // GET: api/Works
        public IEnumerable<WorksOrderModel> Get()
        {
            return db.GetAllActiveWorksOrders();
        }

        // GET: api/Works/5
        [HttpGet("{id}", Name = "GetWorksOrdersById")]
        public WorksOrderModel GetWorksOrdersById(string id)
        {
            return db.GetWorksOrdersByWorkdsOrderNumber(id);
        }

        // POST: api/Works
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Works/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            db.DeleteWorksOrder(id);
            db.DeleteWorksOrderLine(id);
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}