using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        protected override ContentResult Content(string content, string contentType, System.Text.Encoding contentEncoding)
        {
            return base.Content(content, contentType, contentEncoding);
        }
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write("Inside unknown action method handler");
        }


        public ContentResult ShowContent()
        {
            return Content("<a><test>asdsad</test></a>", "text/xml");
        }

      [ActionName("Author")]
    //[NonAction]
        //[HttpPost]
        public string GetAuthor(string controller,string action,string name,string id)
        {
            ViewData["mymesasge"] = "Message from get author action method";
            
            return "Controller:" + controller + " action:"+ action + " name:" + name + "id:" + id;
        }

        public ActionResult Index()
        {
            ViewData["mymesasge"] = "Message from get author action method";
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
