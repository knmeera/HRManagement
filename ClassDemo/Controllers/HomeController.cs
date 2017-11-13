using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDemo.Models;

namespace ClassDemo.Controllers
{
    public class HomeController : Controller
    {
        static List<Application> _appList = new List<Application>();

            public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Product()
        {
            return View();
        }

        public ActionResult ApplicationIndex()
        {
            return View(_appList);
        }

         
        public ActionResult Form()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Form(FormCollection frm)
        {

            var id = Int32.Parse(frm["id"]);
            var name = frm["name"];
            var age = Int32.Parse(frm["age"]);
            var mobile = frm["mobile"];
            var gender = Int32.Parse(frm["gender"]);

            var salutation=string.Empty;
            if (gender == 1)
                salutation = "Miss.";
            else
                salutation = "Mr.";

            _appList.Add(new Application { id = id, name = name, age = age, gender = gender, mobile = mobile });

            //ViewBag.Message = salutation +" "+ name+ " Your application is submitted successful";
            //return View();
            return RedirectToAction("ApplicationIndex");
        }


    }
}