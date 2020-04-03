using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoundTableDal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoundTableWeb.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DeliveryController : ControllerBase
    {
        RoundTableERPContext db = new RoundTableERPContext();

        // GET: api/<DeliveryController>
        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DeliveryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DeliveryController>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<DeliveryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<DeliveryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
