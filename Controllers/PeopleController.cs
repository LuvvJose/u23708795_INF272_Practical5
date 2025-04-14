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
        // GET: People
        public ActionResult PeopleList()
        {
            List<People> people = new List<People>
            {
                new People { StudentNumber = 1234567, FirstName = "Jose", LastName = "Edu", Email = "jose@tuks.co.za", MyLink = "~/HTML/Person1Page.html" },
                new People { StudentNumber = 12345678, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@tuks.co.za", MyLink = "~/HTML/Person2Page.html" },
                new People { StudentNumber = 23708795, FirstName = "John", LastName = "Doe", Email = "john.doe@tuks.co.za", MyLink = "~/HTML/Person3Page.html" },
                new People { StudentNumber = 18345689, FirstName = "Jeff", LastName = "Rizal", Email = "jeff@gmail.com", MyLink = "~/HTML/Person4Page.html" },
                new People { StudentNumber = 28658477, FirstName = "Andres", LastName = "Bonifacio", Email = "Andres@gmail.com", MyLink = "~/HTML/Person5Page.html" }
            };

            return View(people);
        }
    }
}