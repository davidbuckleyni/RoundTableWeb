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
        private const string ApiKeyHeaderName = "ApiKey";
        private const string ClientId = "ClientId";
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
            if (!context.HttpContext.Request.Headers.TryGetValue(ClientId, out var potentialClientId))
            {
                context.Result = new UnauthorizedResult();
                return;


            }
            var ClientId = Guid.TryParse(potentialApiKey, out Guid headerClientId);
            var ApiKey = Guid.TryParse(potentialApiKey, out Guid headerApiKey);
            if (!db.FindKeysByClientIdByApiKey(headerClientId, headerApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            await next();
            //after

        }
    }
}
