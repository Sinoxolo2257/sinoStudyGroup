using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sinoStudyGroup.Models
{
    public class Group
    {
        [Display(Name ="Student Number")]
        public string StudentNo { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}