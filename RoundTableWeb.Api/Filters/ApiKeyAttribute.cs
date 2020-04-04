using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RoundTableDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace RoundTableWeb.Api
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        public  string ApiKeyHeaderName = "ApiKey";
        public   string ClientSecret = "ClientSecret";
        RoundTableERPContext db = new RoundTableERPContext();

        public async  Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //before
            if(!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;

            }

            // before
            if (!context.HttpContext.Request.Headers.TryGetValue(ClientSecret, out var potentialClientId))
            {
                context.Result = new UnauthorizedResult();
                return;


            }
            Guid.TryParse(potentialApiKey, out Guid headerApiKey);
            Guid.TryParse(potentialClientId, out Guid headerClientId);            
            if (!db.FindKeysByClientIdByApiKey(headerApiKey, headerClientId))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            await next();
            //after

        }
    }
}
