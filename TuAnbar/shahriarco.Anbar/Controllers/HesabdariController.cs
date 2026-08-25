using shahriarco.Anbar.Models;
using shahriarco.CommonUnit;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shahriarco.Anbar.Controllers
{
    public class HesabdariController : Controller
    {
        AnbarEntities db = new AnbarEntities();

        public ActionResult Asnad()
        {
            return View();
        }

        public ActionResult HesabdariAnbar(int id = 0)
        {
            if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            ViewBag.AnbarList = db.TAnb.ToList();

            ViewBag.HesabdariAnbarList = db.Database.SqlQuery<QHesabAnbar>("select * from QHesabAnbar where salmali={0} ", new object[] { strSalMali }).ToList();

            THesAnb myModel = new THesAnb();

            if (id != 0 )
            {
                myModel = db.THesAnb.Where(m => m.id == id ).FirstOrDefault();
            }

            if (myModel == null)
            {
                myModel = new THesAnb { SalMali = strSalMali, id=id };
            }

            return View(myModel);
        }

        
        public ActionResult HesabdariAnbar_update(THesAnb myModel)
        {
            int m = 0;


            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(myModel).State = EntityState.Modified;
                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Hesabdari/HesabdariAnbar?id=" + myModel.id.ToString() });
                }
                catch (Exception ex)
                {
                    string strMessage = ErrorHandler.GetErrorMessage(ex);

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/Hesabdari/HesabdariAnbar?id=" + myModel.id.ToString()  });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Hesabdari/HesabdariAnbar?id=" + myModel.id.ToString()  });
        }

        public ActionResult HesabdariKala(int id = 0)
        {
            if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            ViewBag.AnbarList = db.TAnb.ToList();
            ViewBag.KalaList = db.TKala.Where(k=>k.SalMali==strSalMali).ToList();

            ViewBag.HesabdariKalaList = db.Database.SqlQuery<QHesabKala>("select * from QHesabKala where salmali={0} ", new object[] { strSalMali }).ToList();

            THesKala myModel = new THesKala();

            if (id != 0)
            {
                myModel = db.THesKala.Where(m => m.id == id).FirstOrDefault();
            }

            if (myModel == null)
            {
                myModel = new THesKala { SalMali = strSalMali, id = id };
            }

            return View(myModel);
        }

        public ActionResult HesabdariKala_update(THesKala myModel)
        {
            int m = 0;


            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(myModel).State = EntityState.Modified;
                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Hesabdari/HesabdariKala?id=" + myModel.id.ToString() });
                }
                catch (Exception ex)
                {
                    string strMessage = ErrorHandler.GetErrorMessage(ex);

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/Hesabdari/HesabdariKala?id=" + myModel.id.ToString() });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Hesabdari/HesabdariKala?id=" + myModel.id.ToString() });
        }

        public ActionResult HesabdariMarkaz(int id = 0)
        {
            if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            ViewBag.MarkazList = db.TMar.Where(k => k.SalMali == strSalMali).ToList();

            ViewBag.HesabdariMarkazList = db.Database.SqlQuery<QHesabMarkaz>("select * from QHesabMarkaz where salmali={0} ", new object[] { strSalMali }).ToList();

            THesMar myModel = new THesMar();

            if (id != 0)
            {
                myModel = db.THesMar.Where(m => m.id == id).FirstOrDefault();
            }

            if (myModel == null)
            {
                myModel = new THesMar { SalMali = strSalMali, id = id };
            }

            return View(myModel);
        }


        public ActionResult HesabdariMarkaz_update(THesMar myModel)
        {
            int m = 0;


            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(myModel).State = EntityState.Modified;
                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Hesabdari/HesabdariMarkaz?id=" + myModel.id.ToString() });
                }
                catch (Exception ex)
                {
                    string strMessage = ErrorHandler.GetErrorMessage(ex);

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/Hesabdari/HesabdariMarkaz?id=" + myModel.id.ToString() });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Hesabdari/HesabdariMarkaz?id=" + myModel.id.ToString() });
        }


        public ActionResult HesabdariMotefaregheh(int id = 0)
        {
            if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            ViewBag.HesabdariList = db.Database.SqlQuery<QHesab>("select * from QHesab where salmali={0} ", new object[] { strSalMali }).ToList();

            THes myModel = new THes();

            if (id != 0)
            {
                myModel = db.THes.Where(m => m.id == id).FirstOrDefault();
            }

            if (myModel == null)
            {
                myModel = new THes { SalMali = strSalMali, id = id };
            }

            return View(myModel);
        }


        public ActionResult HesabdariMotefaregheh_update(THes myModel)
        {
            int m = 0;


            if (ModelState.IsValid)
            {
                try
                {
                    if (myModel.id == 0)
                    {
                        string strSalMali = db.TCurrent.FirstOrDefault().SalMali;
                        //int mm = db.THes.Max(a => a.Radif);

                        //mm++;
                        //myModel.Radif = mm;

                        myModel.Type = 2;
                        myModel.SalMali = strSalMali;

                        db.THes.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }

                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Hesabdari/HesabdariMotefaregheh?id=" + myModel.id.ToString() });
                }
                catch (Exception ex)
                {
                    string strMessage = ErrorHandler.GetErrorMessage(ex);

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/Hesabdari/HesabdariMotefaregheh?id=" + myModel.id.ToString() });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Hesabdari/HesabdariMotefaregheh?id=" + myModel.id.ToString() });
        }


    }
}