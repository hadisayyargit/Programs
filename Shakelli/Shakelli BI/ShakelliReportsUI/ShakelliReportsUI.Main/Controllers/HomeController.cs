using ShakelliReportsUI.DataLayer.Models;
using ShakelliReportsUI.CommonUnits.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace ShakelliReportsUI.Main.Controllers
{
    public class HomeController : Controller
    {
        private ShakelliDWEntities db = new ShakelliDWEntities();
        public ActionResult Index()
        {

            

            if (HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] == null)
            {
                //Response.Redirect("~/Account/Login");
                //return RedirectToAction("Login", "Account"); 
                return View();
            }
            else
            {

                Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "active";
                string m = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]).ToString();
                Session[CommonUnits.GeneralModule.m_MessageList] = db.AppNotification.Where(a => (a.NotificationType == 0 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
                Session[CommonUnits.GeneralModule.m_NotificationList] = db.AppNotification.Where(a => (a.NotificationType == 1 && (a.Receivers == null || a.Receivers.Contains(m)) && (a.Readers == null || !a.Readers.Contains(m)))).ToList();
                return View();
            }

           

           

        }

        //public FileResult DownloadXpi1()
        public ActionResult DownloadXpi()
        {
            try
            {                
                string path = Server.MapPath("~/");
                byte[] fileBytes = System.IO.File.ReadAllBytes(path + "\\ffclickonce.xpi");
                //byte[] fileBytes = System.IO.File.ReadAllBytes(@"D:\Documents\Hadi\admin lab RTL template\500.html");
   
                //string s5 = Server.MapPath("");
                string fileName = "ffclickonce.xpi";
                return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            }
            catch(Exception ex)
            {
                //return null;
                ViewBag.Message = ex.Message;
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ViewBag.Message, Title = "خطا", SubTitle = "خطا در بارگیری", MessageType = "Error", CallerAction = "Index", CallerController = "Home" };
                Session[CommonUnits.GeneralModule.m_CurrentError] = null;
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
            }

        }

        public ActionResult About()
        {
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "active"; 
            
            return View();
        }

        public ActionResult Contact()
        {
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "active";

            return View(new MessageModel());
        }
       
        public ActionResult Gallery()
        {
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "active";

            return View();
        }

        public ActionResult Icons()
        {
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "active";

            return View();
        }


        //public ActionResult Faq()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult blog()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult SendMail(string strName,string strBody,string strFrom, string strPhone)
        {
            string strSubject = strName + "-" + strPhone;

            try
            {
                //System.Net.Mail.MailMessage myMessage = new System.Net.Mail.MailMessage(strFrom, "contact@shakelli.ir");
                //myMessage.Subject = strSubject;
                //myMessage.Body = strBody;
                //myMessage.IsBodyHtml = true;
                //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                //smtp.Credentials = new System.Net.NetworkCredential("sh@gmail.com", "46456");
                //smtp.EnableSsl = true;
                //smtp.Port = 25;
                //smtp.Send(myMessage);

                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 25;
                WebMail.EnableSsl = true;
                WebMail.UserName = "aa@gmail.com";
                WebMail.Password = "546567";
                WebMail.From = strFrom;
                WebMail.Send("contact@shakelli.ir", strSubject, strBody);

                ViewBag.Message = "ایمیل فرستاده شد";

                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ViewBag.Message, Title = "ارسال", SubTitle = "", MessageType = "Success", CallerAction = "Contact", CallerController = "Home" };
                return View("MessageView", Session[CommonUnits.GeneralModule.m_MessageModel]);
                //string body = string.Format("<div style=
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;

                Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "", MessageType = "Error", CallerAction = "Contact", CallerController = "Home" };
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);
            }

            //return RedirectToAction("Contact");
        }


        public ActionResult HandleError(MessageModel myModel)
        {
            if (Session[CommonUnits.GeneralModule.m_CurrentError] != null)
            {
                if (((Exception)Session[CommonUnits.GeneralModule.m_CurrentError]).InnerException != null)
                {
                    myModel.MessageBody = ((Exception)Session[CommonUnits.GeneralModule.m_CurrentError]).InnerException.Message;
                    if (((Exception)Session[CommonUnits.GeneralModule.m_CurrentError]).InnerException.InnerException != null)
                        myModel.MessageBody =  myModel.MessageBody + "--" + ((Exception)Session[CommonUnits.GeneralModule.m_CurrentError]).InnerException.InnerException.Message;
                }
            }


            CultureInfo ci = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;


            if (myModel.MessageBody.Contains("The server was not found or was not accessible"))
                myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_server_not_accessible", ci);
            else if (myModel.MessageBody.Contains("timeout"))
                myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_timeout", ci);
            else if (myModel.MessageBody.Contains("REFERENCE constraint"))
                myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_foreignkey", ci) + "\r\nخطای داخلی:" + "\r\n" + myModel.MessageBody;
            else if (myModel.MessageBody.Contains("duplicate key"))
                myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_duplicatekey", ci) + "\r\nخطای داخلی:" + "\r\n" + myModel.MessageBody;
            else if (myModel.MessageBody.Contains("expects parameter"))
            {
                string strParameter = myModel.MessageBody.Split(new char[] { '@' }).ElementAt(1).Split().ElementAt(0).Replace("'","").Replace(",","");
                try
                {
                    strParameter = db.Glossary.Where(a => a.Lname.ToLower() == strParameter).FirstOrDefault().Pname;
                }
                catch
                {

                }

                myModel.MessageBody = new ResourceManager("ShakelliReportsUI.CommonUnits.Resources.Messages", typeof(Messages).Assembly).GetString("err_expectsparameter", ci);
                myModel.MessageBody = myModel.MessageBody.Replace("<p>", "* " + strParameter + " *");
            }


            /*
                else if (ex.Message.Contains("Login failed for user"))
                    strRes = "خطای راهبری: شناسه کاربری و یا رمز داخلی اشتباه است";
                else
                    strRes = ex.Message;
             
             */

            return View("MessageView", myModel);
        }

        
        public ActionResult MessageInvoked(MessageModel myModel)
        {

            return RedirectToAction(myModel.CallerAction, myModel.CallerController);
        }

        public ActionResult GeneralDirectBrowser(string urlpath)
        {
            ReportModel myModel = new ReportModel();
            myModel.UrlPath = urlpath;
            return View(myModel);
        }

        //public ActionResult OkReportPartial(ReportModel p)
        //{
        //    return RedirectToAction(p.ContollerAction, p.ContollerName, p); 
        //}


        public ActionResult GoMenu(int objectid,string urlPath)
        {
            return Redirect(urlPath);
        }

    }
}