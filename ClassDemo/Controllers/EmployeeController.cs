using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassDemo.Models;
using System.IO;

namespace ClassDemo.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> _emplist = new List<Employee>();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult EmpIndex()
        {
            return View(_emplist);
        }
        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection emp)
        {
            try
            {
                // TODO: Add insert logic here
                var id = Int32.Parse(emp["empid"]);
                var name = emp["firstname"];
                var lname = emp["lastname"];
                var gender = emp["gender"];
                //var dob = DateTime.ParseExact(emp["dob"],"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
                var dob = emp["dob"];
                var street1 = emp["street1"];
                var street2 = emp["street2"];
                var city = emp["city"];
                var pin = Int32.Parse(emp["pin"]);
                var dist = emp["dist"];
                var state = emp["state"];
                var country = emp["country"];
                var exp = emp["exp"];
                var workstate = emp["workstate"];
                var workload = emp["workload"];
                var workcountry = emp["workcountry"];
                var address = emp["address"];
                var enable = emp["enable"];

                //HttpPostedFileBase photo = Request.Files["photo"];

                //if (photo != null && photo.ContentLength > 0)
                //{
                //    var fileName = Path.GetFileName(photo.FileName);
                //    photo.SaveAs(Path.Combine(Server.MapPath("~/Images/"), fileName));
                //}
                //filename = "~/Images/" + photo.FileName

                _emplist.Add(new Employee { empid = id, firstname = name, lastname = lname, gender = gender, dob = dob, street1 = street1, street2 = street2, city = city, pin = pin, dist = dist, state = state, country = country, exp = exp, workload = workload, workstate = workstate, workcountry = workcountry, address = address, enable = enable });
                return RedirectToAction("EmpIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
