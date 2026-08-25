using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using khordadmanager.Models;

namespace khordadmanager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult portfolio()
        {
            ViewBag.Message = "my works";

            return View();
        }
        public ActionResult AppBrief1(ProjectModel mymodel)
        {
            return View(mymodel);
        }
 
    }
}
