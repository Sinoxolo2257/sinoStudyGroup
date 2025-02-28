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
        public ActionResult Index()
        {
            List<Models.group> members = new List<Models.group>();

            members.Add(new Models.group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
            members.Add(new Models.group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
            members.Add(new Models.group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
            members.Add(new Models.group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
            members.Add(new Models.group { StudentNo = "u22579428", FirstName = "Sinoxolo", Surname = "Sokoyi", Email = "u225794282tuks.co.za" });
            return View(members);
        }
    }
}