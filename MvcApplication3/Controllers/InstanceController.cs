using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class InstanceController : Controller
    {
        //
        // GET: /Instance/

        public static List<InstanceInfo> instancesList = new List<InstanceInfo>();

        public ActionResult Index()
        {
            LoadInstanceList();
            ViewData["Header"] = "Instance Summary List";
            return View(instancesList);
        }
       

       
        [HttpPost]
        public ActionResult ListInstances(InstanceInfo1 info)
        {
            if(!ModelState.IsValid)
            {
                return View(info);
            }

            return View(info);
        }

        private void LoadInstanceList()
        {
            if(instancesList.Count==0)
            {
                instancesList.Add(new InstanceInfo() { InstanceID = 1, InstanceName = "A", VCPU = 2, RAM = "30GB", TimeSinceCreated = "1 month" });
                instancesList.Add(new InstanceInfo() { InstanceID = 2, InstanceName = "B", VCPU = 2, RAM = "130GB", TimeSinceCreated = "2 month" });
                instancesList.Add(new InstanceInfo() { InstanceID = 3, InstanceName = "C", VCPU = 2, RAM = "230GB", TimeSinceCreated = "3 month" });
                instancesList.Add(new InstanceInfo() { InstanceID = 4, InstanceName = "D", VCPU = 2, RAM = "330GB", TimeSinceCreated = "4 month" });
                instancesList.Add(new InstanceInfo() { InstanceID = 5, InstanceName = "E", VCPU = 2, RAM = "430GB", TimeSinceCreated = "5 month" });
            }
        }
        public ActionResult ListInstances()
        {
            return View();
        }

    }
}
