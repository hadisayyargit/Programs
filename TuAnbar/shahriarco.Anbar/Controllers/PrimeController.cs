using shahriarco.CommonUnit;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shahriarco.Anbar.Models;


namespace shahriarco.Anbar.Controllers
{
    public class PrimeController : Controller
    {
        // GET: Prime

        AnbarEntities db=new AnbarEntities();
        public ActionResult Anbar()
        {
            List<TAnb> AnbarList = db.TAnb.ToList();
            ViewBag.AnbarList = AnbarList;
            return View();
        }

        public ActionResult Anbar_Update(int anbarcode=0)
        {
            TAnb myModel = db.TAnb.Where(m => m.AnbarCode == anbarcode).FirstOrDefault();

            if(myModel==null)
                myModel=new TAnb{ AnbarCode=0};

            return View(myModel);
        }

        //[AllowAnonymous]
        [HttpPost]
        public ActionResult Anbar_Update(TAnb myModel)
        {
            int m = 0;

            if (ModelState.IsValid)
            {
                try
                {
                    if (myModel.AnbarCode == 0)
                    {
                        int mm = db.TAnb.Max(a => a.AnbarCode);
                        string strSalMali = db.TCurrent.FirstOrDefault().SalMali;
                        mm++;
                        myModel.AnbarCode = mm;


                        myModel.SalMali = strSalMali;

                        db.TAnb.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }

                    //myModel.AuthorId = ((AppUser)Session[Helper.GeneralModule.m_CurrentUser]).UserId;

                     m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Prime/anbar" });
                }
                catch (Exception ex)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = ex.Message, BackUrl = "~/prime/Anbar_Update" });
                }

                
            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Prime/Anbar_Update" });

            //return View(myModel);
        }

        public ActionResult Anbar_Delete(int anbarcode = 0)
        {
            TAnb myAnbar = db.TAnb.Where(m => m.AnbarCode == anbarcode).First();

            try
            {
                if (myAnbar.AnbarCode != 0)
                {
                    //db.Entry(myModel).State = EntityState.Deleted;
                    db.TAnb.Remove(myAnbar);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {
                string strMessage = ErrorHandler.GetErrorMessage(ex);

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/Prime/Anbar_update?anbarcode="+anbarcode.ToString() });
            }


            return RedirectToAction("Anbar");

        }


        /// <summary>
        /// Kala
        /// </summary>
        /// <param name="anbarcode"></param>
        /// <param name="kalacode"></param>
        /// <returns></returns>
        public ActionResult Kala(int anbarcode=0,int kalacode=0)
        {
            //if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            //{
            //    return RedirectToAction("Login", "Account");
            //}

            

            //return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "info",Title="موفقیت", SubTitle = "Ooops! Something went wrong. ", MessageBody = "But don't worry - we'll fix that soon. ", CallerController = "Home", CallerAction = "Index" });
            List<TAnb> AnbarList = db.TAnb.ToList();
            ViewBag.AnbarList = AnbarList;
            List<TKala> KalaList = db.TKala.Where(k=>k.AnbarCode==anbarcode).ToList();
            ViewBag.KalaList = KalaList;

            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            List<TVahed> VahedList = db.TVahed.Where(v=>v.SalMali==strSalMali).ToList();
            ViewBag.VahedList = VahedList;

            TKala myModel = new TKala();

            if (kalacode!=0)
            {
                myModel = db.TKala.Where(k => k.KalaCode == kalacode).FirstOrDefault();
            }

            if(myModel==null)
            {
                myModel = new TKala { KalaCode = 0,AnbarCode=anbarcode };
            }

            return View(myModel);
        }



        public ActionResult GetKala(int kalacode)
        {
            TKala result1 = db.TKala.Where(k => k.KalaCode == kalacode).FirstOrDefault();

            //var result = db.TUser.Where(k => k.IDUser == kalacode).FirstOrDefault();

            //result = new TKala { AnbarCode = 1, KalaName = "علی" };
            var result = new TKala
            {
                AnbarCode = result1.AnbarCode,
                KalaCode = result1.KalaCode,
                KalaName = result1.KalaName,                
                KalaEsteghrar = result1.KalaEsteghrar,
                KalaProperty = result1.KalaProperty,
                KalaShomareh = result1.KalaShomareh,
                KalaVahedCode = result1.KalaVahedCode,
                KalaMomaiez = result1.KalaMomaiez,
                KalaMin = result1.KalaMin,
                KalaSefPoint = result1.KalaSefPoint,
                KalaMax = result1.KalaMax,
                KalaArzType = result1.KalaArzType,
                KalaZaribVahed = result1.KalaZaribVahed,
                KalaGhesmat = result1.KalaGhesmat,
                SalMali = result1.SalMali
            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult kala_Update(TKala myModel)
        {
            int m = 0;

            if (ModelState.IsValid)
            {
                try
                {
                    if (myModel.KalaCode == 0)
                    {
                        int mm = db.TKala.Max(a => a.KalaCode);
                        string strSalMali = db.TCurrent.FirstOrDefault().SalMali;
                        mm++;
                        myModel.KalaCode = mm;


                        myModel.SalMali = strSalMali;

                        db.TKala.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }

                    //myModel.AuthorId = ((AppUser)Session[Helper.GeneralModule.m_CurrentUser]).UserId;

                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Prime/kala?anbarcode="+myModel.AnbarCode.ToString()+"&kalacode=" +myModel.KalaCode.ToString()});
                }
                catch (Exception ex)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = ex.Message, BackUrl = "~/prime/kala_Update" });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Prime/kala_Update" });

            //return View(myModel);
        }
        /// <summary>
        /// markaz
        /// </summary>
        /// <returns></returns>
        public ActionResult Markaz()
        {
            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;
            ViewBag.MarkazList = db.TMar.Where(m=>m.SalMali==strSalMali).ToList();

            return View();
        }

        public ActionResult Markaz_Update(int markazcode = 0)
        {
            TMar myModel = db.TMar.Where(m => m.MarkazCode == markazcode).FirstOrDefault();

            if (myModel == null)
                myModel = new TMar { MarkazCode = 0 };

            return View(myModel);
        }

        //[AllowAnonymous]
        [HttpPost]
        public ActionResult Markaz_Update(TMar myModel)
        {
            int m = 0;

            if (ModelState.IsValid)
            {
                try
                {
                    if (myModel.MarkazCode == 0)
                    {
                        int mm = db.TMar.Max(a => a.MarkazCode);
                        string strSalMali = db.TCurrent.FirstOrDefault().SalMali;
                        mm++;
                        myModel.MarkazCode = mm;


                        myModel.SalMali = strSalMali;

                        db.TMar.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }

                    //myModel.AuthorId = ((AppUser)Session[Helper.GeneralModule.m_CurrentUser]).UserId;

                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/Prime/markaz" });
                }
                catch (Exception ex)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = ex.Message, BackUrl = "~/prime/markaz_Update" });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/Prime/markaz_Update" });

            //return View(myModel);
        }

        public ActionResult markaz_Delete(int markazcode = 0)
        {
            TMar myMarkaz = db.TMar.Where(m => m.MarkazCode== markazcode).First();

            try
            {
                if (myMarkaz.MarkazCode != 0)
                {
                    //db.Entry(myModel).State = EntityState.Deleted;
                    db.TMar.Remove(myMarkaz);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {
                string strMessage = ex.Message;
                if (ex.InnerException != null)
                    strMessage = ex.InnerException.InnerException.Message;

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/Prime/markaz_update?markazcode=" + markazcode.ToString() });
            }


            return RedirectToAction("Markaz");

        }

    }
}