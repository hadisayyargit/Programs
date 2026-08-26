using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SazianPayesh.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Project()
        {
            ViewBag.MenuProjectActive = "active";
            ViewBag.MenuProjectOpen = "open";
            ViewBag.SubMenuProjectActive = "active";

            return View();
        }

        public ActionResult Activity()
        {
            ViewBag.MenuProjectActive = "active";
            ViewBag.MenuProjectOpen = "open";
            ViewBag.SubMenuActivityActive = "active";

            return View();
        }
    }
}