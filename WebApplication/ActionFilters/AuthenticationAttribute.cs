using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.ActionFilters
{
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (String.IsNullOrEmpty(context.HttpContext.Session.GetString("loggedUser")))
                context.Result = new RedirectToActionResult("Login", "Home", new { });
        }
    }
}
