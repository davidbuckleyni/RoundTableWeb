using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoundTableDal;


namespace RoundTableWeb.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
  
    public class ApiKeysController : ControllerBase
    {
        RoundTableERPContext db = new RoundTableERPContext();
        [HttpGet]
        public int Get(Guid ApiKey, Guid ClientdId)
        {            
            if (!db.FindKeysByClientIdByApiKey(ApiKey, ClientdId))            {
                return StatusCodes.Status401Unauthorized;
            }else
                return StatusCodes.Status200OK;
        }

    }
}
