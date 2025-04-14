using Prac2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // ✅ Static list that holds all people globally (simulated in-memory database)
        private static List<People> peopleList = new List<People>
        {
            new People { StudentNumber = 1234567, FirstName = "Jose", LastName = "Edu", Email = "jose@tuks.co.za"},
            new People { StudentNumber = 12345678, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@tuks.co.za" },
            new People { StudentNumber = 23708795, FirstName = "John", LastName = "Doe", Email = "john.doe@tuks.co.za" },
            new People { StudentNumber = 18345689, FirstName = "Jeff", LastName = "Rizal", Email = "jeff@gmail.com" },
            new People { StudentNumber = 28658477, FirstName = "Andres", LastName = "Bonifacio", Email = "Andres@gmail.com" }
        };

        // GET: People list
        public ActionResult PeopleList()
        {
            return View(peopleList); // ✅ Return the shared list
        }

        // GET: Show form to create new person
        public ActionResult CreateNew()
        {
            return View();
        }

        // POST: Add person to list
        [HttpPost]
        public ActionResult CreateNew(People person)
        {
            if (ModelState.IsValid)
            {
                peopleList.Add(person); // ✅ Add to shared list
                return RedirectToAction("PeopleList");
            }

            return View(person); // If validation fails
        }
    }
}