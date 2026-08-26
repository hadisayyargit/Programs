using ShakelliReportsUI.CommonUnits;
using ShakelliReportsUI.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShakelliReportsUI.Main.Controllers
{
    public class AdministrationController : Controller
    {
        private ShakelliDWEntities db = new ShakelliDWEntities();


        public ActionResult appNotifications(string activetab = "")
        {
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "active";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "";

            ViewBag.AppNotification = db.AppNotification.ToList();

            string submenuclass = GeneralModule.m_ActiveSubMenu + "appnotification";
            Session[submenuclass] = "active";




            ViewBag.Tab_Messages_Active = "";
            ViewBag.Tab_Notifications_Active = "";

            switch (activetab)
            {
                case "Tab_Messages":
                    ViewBag.Tab_Messages_Active = "active";
                    break;

                case "Tab_Notifications":
                    ViewBag.Tab_Notifications_Active = "active";
                    break;
                
                default:
                    ViewBag.Tab_Messages_Active = "active";
                    break;
            }

            if (Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_CurrentUserName].ToString() != "admin")
            {
                int m = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]);
                string s = m.ToString();
                ViewBag.AppNotification = db.AppNotification.Where(a => (a.Sender==m || a.Receivers == null || a.Receivers.Contains(s))).ToList();
            }

            //ViewBag.Receiver = db.AppUser.ToList();

            return View();
        }

        public ActionResult AppNotification_update(AppNotification myModel)
        {
            try
            {
                if (Session[CommonUnits.GeneralModule.m_ProgramMode] == "edit")
                {
                    if (ModelState.IsValid)
                    {
                        if (myModel.Receivers == "null")
                            myModel.Receivers = null;

                        db.Entry(myModel).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                    }
                    
                }

                else
                {
                    if (ModelState.IsValid)
                    {
                        System.Globalization.PersianCalendar myCalendar = new PersianCalendar();
                        myModel.NotificationDate = myCalendar.GetYear(DateTime.Today) + "/" + myCalendar.GetMonth(DateTime.Today).ToString("00") + "/" + myCalendar.GetDayOfMonth(DateTime.Today).ToString("00");

                        if (myModel.Receivers == "null")
                            myModel.Receivers = null;

                        db.AppNotification.Add(myModel);
                        db.SaveChanges();

                    }

                    //return View("MessageView", new MessageModel() { MessageBody = "5" });
                    
                }

                string strTab = (myModel.NotificationType == 0) ? "Tab_Messages" : "Tab_Notifications";
                return RedirectToAction("appNotifications", "Administration", routeValues: new { activetab = strTab });
            }

            catch (Exception ex)
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "افزودن پیام", MessageType = "Error", CallerAction = "AppNotification_cancel", CallerController = "Administration" };

                Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);

            }
        }

        /**********************************************
                           AppNotification
         **********************************************/
        public ActionResult AppNotification_edit(int notificationid)
        {
            Session[CommonUnits.GeneralModule.m_ProgramMode] = "edit";
            AppNotification myModel = db.AppNotification.Find(notificationid);

            List<WorkListModel> myPersonList = (from u in db.AppUser
                                                join p in db.Person on u.PersonId equals p.PersonId into g2
                                                orderby u.UserId
                                                from up in g2.DefaultIfEmpty()
                                                select new WorkListModel
                                                {
                                                    ItemId = u.UserId,
                                                    ItemDs = (up.LastName == null ? "" : up.LastName) + "-" + (up.FirstName == null ? "" : up.FirstName) + "-" + (u.UserName == null ? "" : u.UserName)
                                                }).ToList();

            ViewBag.Receiver = myPersonList;
            return View(myModel);
        }

        public ActionResult AppNotification_create(int notificationtype = 0)
        {
            Session[CommonUnits.GeneralModule.m_ProgramMode] = "create";
            AppNotification myModel   = new AppNotification();

      
            myModel.Sender =(int) Session[CommonUnits.GeneralModule.m_CurrentUserId];
            myModel.NotificationType = notificationtype;

            List<WorkListModel> myPersonList = (from u in db.AppUser
                                                join p in db.Person on u.PersonId equals p.PersonId into g2
                                                orderby u.UserId
                                                from up in g2.DefaultIfEmpty()
                                                select new WorkListModel
                                                {
                                                    ItemId = u.UserId,
                                                    ItemDs = (up.LastName == null ? "" : up.LastName) + "-" + (up.FirstName == null ? "" : up.FirstName) + "-" + (u.UserName == null ? "" : u.UserName)
                                                }).ToList();

            ViewBag.Receiver = myPersonList;

            return View("AppNotification_edit", myModel);
        }

        public ActionResult AppNotification_cancel(AppNotification myModel)
        {
            string strTab = (myModel.NotificationType == 0) ? "Tab_Messages" : "Tab_Notifications";
            return RedirectToAction("appNotifications", "Administration", routeValues: new { activetab = strTab });
        }

        public ActionResult AppNotification_delete(int notificationid = 0)
        {
            AppNotification myModel = db.AppNotification.Find(notificationid);

            
            return View(myModel);
        }

        public ActionResult AppNotification_delete_confirm(AppNotification myModel)
        {
            try
            {

                db.Entry(myModel).State = EntityState.Deleted;
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ex.Message, Title = "خطا", SubTitle = "حذف پیام", MessageType = "Error", CallerAction = "AppNotification_cancel", CallerController = "Administration" };

                Session[CommonUnits.GeneralModule.m_CurrentError] = ex;
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);

            }

            string strTab = (myModel.NotificationType == 0) ? "Tab_Messages" : "Tab_Notifications";
            return RedirectToAction("appNotifications", "Administration", routeValues: new { activetab = strTab });

        }

        public ActionResult ShowNotify(int notificationid)
        {
            AppNotification myNotification = db.AppNotification.Find(notificationid);
            try
            {
                myNotification.Readers+=","+Session[CommonUnits.GeneralModule.m_CurrentUserId].ToString();
                db.Entry(myNotification).State = EntityState.Modified;
                db.SaveChanges();
                
            }
            catch
            {

            }

            TempData["msg"] = myNotification.Body;
            //return Content("<script language='javascript' type='text/javascript'>alert('" + myNotification.Body + "');</script>");
            return RedirectToAction("Index", "Home");
        }


	}
}