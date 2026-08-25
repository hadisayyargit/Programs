using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shahriarco.Anbar.Models;
using shahriarco.CommonUnit;

namespace shahriarco.Anbar.Controllers
{
    //[Authorize]
    //[Authorize(Users = "admin, Johnny")]
    //[Authorize(Roles = "Admin, Super User")]

    public class HomeController : Controller
    {
        //[AllowAnonymous]
        public ActionResult Index()
        {
            //if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            //{
            //    return RedirectToAction("Login", "Account");
            //}

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult HandleMessage(MessageModel myModel)
        {


            /*
                       CultureInfo ci = new CultureInfo("fa-IR");
                       Thread.CurrentThread.CurrentCulture = ci;
                       Thread.CurrentThread.CurrentUICulture = ci;


                       if (myModel.MessageBody.Contains("The server was not found or was not accessible"))
                           myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_server_not_accessible", ci);
                       else if (myModel.MessageBody.Contains("timeout"))
                           myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_timeout", ci);

                       */

            //return View("MessageView", new MessageModel { MessageType = "Error", SubTitle = "خطا",MessageBody="کد تکراری",CallerController="Home",CallerAction="Index" });
            return View("MessageView", myModel);
        }


    }
}