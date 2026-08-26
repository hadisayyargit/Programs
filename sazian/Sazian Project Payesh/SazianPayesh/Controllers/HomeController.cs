using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SazianPayesh.Models;

namespace SazianPayesh.Controllers
{
    
    public class HomeController : Controller
    {
        SazianModel db = new SazianModel();
        public ActionResult Index()
        {
            
            ViewBag.MenuHomeActive = "active";
            return View();
        }

        public ActionResult goPage(string searchcode)
        {
            return View("index");
        }
        public ActionResult Role()
        {
            ViewBag.MenuPrimeActive = "active";
            ViewBag.MenuPrimeOpen = "open";
            ViewBag.SubMenuRoleActive = "active";

            return View();
        }

        public ActionResult Department()
        {
            ViewBag.MenuPrimeActive = "active";
            ViewBag.MenuPrimeOpen = "open";
            ViewBag.SubMenuDepartmentActive = "active";

            List<SazianPayesh.Models.Department> myList = db.Department.ToList();
            ViewBag.DepartmentList =  myList;
            return View();
        }


    }
}