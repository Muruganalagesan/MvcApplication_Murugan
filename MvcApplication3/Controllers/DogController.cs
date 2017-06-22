using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class DogController : Controller
    {
        //
        // GET: /Dog/

        public static List<Models.Dog> doglist = new List<Models.Dog>();

        public void PopulateDogList()
        {
            if(doglist.Count==0)
            {

           
           // doglist.Clear();
            doglist.Add(new Dog() { DogId=1,Name="MyDog",Age=12}  );
            doglist.Add(new Dog() { DogId = 2, Name = "MyDog1", Age = 12 });
            doglist.Add(new Dog() { DogId = 3, Name = "MyDog2", Age = 13 });
            doglist.Add(new Dog() { DogId = 4, Name = "MyDog3", Age = 14 });
            }
        }


        public ActionResult MyList()
        {
            return View(doglist);


           
        }

        public ContentResult MyContentList()
        {
            String text= System.IO.File.ReadAllText(Server.MapPath( "~\\Content\\test.html"));

            return Content(text, "text/xml");



        }
        public ActionResult Index()
        {
            PopulateDogList();

            return View(doglist);
        }

        public ActionResult Create()
        {
            

            return View();
        }

        [HttpPost]
        public ActionResult Create(Dog newdog)
        {
            if (!ModelState.IsValid)
            {
                return View(newdog);
            }

            else
            {
                doglist.Add(newdog);
            }
            return View("Index",doglist);
        }
    }
}
