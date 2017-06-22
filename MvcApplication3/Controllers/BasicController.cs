using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class BasicController:IController
    {
        public void Execute(System.Web.Routing.RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("Hello from basic controller");
        }
    }
}