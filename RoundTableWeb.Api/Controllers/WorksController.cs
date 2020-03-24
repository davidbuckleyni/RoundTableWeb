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
    [Route("api/[controller]")]
    [ApiController]
    public class WorksController : ControllerBase
    {
        RoundTableERPContext db = new RoundTableERPContext();

        // GET: api/Works
        public IEnumerable<WorksOrder> Get()
        {
            return db.GetWorksOrdersByAccountNumber();
        }

        // GET: api/Works/5
        [HttpGet("{id}", Name = "GetWorksOrdersById")]
        public string GetWorksOrdersById(int id)
        {
            return "value";
        }

        // POST: api/Works
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Works/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }



        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}