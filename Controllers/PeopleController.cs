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
        private static List<People> peopleList = new List<People>
        {
           
        };

        // GET: People list
        public ActionResult PeopleList()
        {
            return View(peopleList); 
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
                peopleList.Add(person); 
                return RedirectToAction("PeopleList");
            }

            return View(person); 
        }
    }
}