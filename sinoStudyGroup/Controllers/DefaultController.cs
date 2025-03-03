using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinoStudyGroup.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        private static List<Group> members = new List<Group> //kep list at class level to keep persistance while app is running (list in memory while app is running)
        {
             members.Add(new Models.Group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
             members.Add(new Models.Group { StudentNo = "u22579428", FirstName = "Naledi", Surname = "Nkwana", Email = "u24687945tuks.co.za" });
             members.Add(new Models.Group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
             members.Add(new Models.Group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
        };
        public ActionResult Index()
        {
            return View(members);
        }
    }
}