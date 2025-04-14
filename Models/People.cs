using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prac2.Models
{
	public class People
	{
        [Display(Name = "Student Number")]
        public int StudentNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Profile Link")]
        public string MyLink { get; set; }
    }
}