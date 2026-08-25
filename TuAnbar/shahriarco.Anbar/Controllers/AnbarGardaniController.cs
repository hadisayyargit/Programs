using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shahriarco.Anbar.Models;
using shahriarco.CommonUnit;
using System.Data.Entity;

namespace shahriarco.Anbar.Controllers
{
    public class AnbarGardaniController : Controller
    {
        AnbarEntities db = new AnbarEntities();

        // GET: AnbarGardani
        public ActionResult Madrak(int anbarcode = 0, int madrakcode = 0, byte madraktype=0)
        {
            if (HttpContext.Session[GeneralModule.m_CurrentUser] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            List<TAnb> AnbarList = db.TAnb.ToList();
            ViewBag.AnbarList = AnbarList;

            //db.TKala.Where(k => k.AnbarCode == anbarcode).ToList();
            var KalaList = (from k in db.TKala
                            where (k.AnbarCode == anbarcode)
                            select new KalaView
                            {
                                KalaCode = k.KalaCode
                                ,
                                KalaName = k.KalaCode.ToString()+"-" + k.KalaName
                            }).ToList();

            ViewBag.KalaList = KalaList;

            List<TMar> MarkazList = db.TMar.Where(v => v.SalMali == strSalMali).ToList();
            ViewBag.MarkazList = MarkazList;

            List<TMad> MadList = db.TMad.Where(m => m.SalMali == strSalMali & m.MadrakType == madraktype & m.AnbarCode == anbarcode).ToList();
            ViewBag.MadList = MadList;

            TMad myModel = new TMad { MadrakCode = 0, AnbarCode = anbarcode, MadrakType = madraktype };

            if (anbarcode != 0 && madrakcode != 0)
            {
                myModel = db.TMad.Where(m => m.MadrakType == madraktype & m.AnbarCode == anbarcode & m.MadrakCode == madrakcode).FirstOrDefault();
            }

            if (myModel == null)
            {
                myModel = new TMad { MadrakCode = 0, AnbarCode = anbarcode, MadrakType = madraktype };
            }

            return View(myModel);
        }


        public ActionResult GetMadrak(int anbarcode = 0, int madrakcode = 0, byte madraktype = 0)
        {
            //var result = db.QMadrakItem2.Where(m => m.MadrakType == 0 & m.AnbarCode == anbarcode & m.MadrakCode == madrakcode).ToList();
            var result = db.Database.SqlQuery<QMadrakItem2>("select * from QMadrakItem2 where madraktype={0} and anbarcode={1} and madrakcode={2}", new object[] { madraktype, anbarcode, madrakcode }).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult madrak_Delete(int anbarcode = 0, int madrakcode = 0, byte madraktype = 0)
        {
            try
            {
                TMad myMadrak = db.TMad.Where(m => m.MadrakType == madraktype & m.AnbarCode == anbarcode & m.MadrakCode == madrakcode).First();

                if (myMadrak.AnbarCode != 0)
                {
                    //db.Entry(myModel).State = EntityState.Deleted;
                    db.TMad.Remove(myMadrak);
                    db.SaveChanges();

                }


            }
            catch (Exception ex)
            {
                string strMessage = ErrorHandler.GetErrorMessage(ex);

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/AnbarGardani/Madrak?madraktype=" + madraktype + "&anbarcode=" + anbarcode.ToString() + "&madrakcode=" + madrakcode.ToString() });
            }


            return RedirectToAction("Madrak", routeValues: new {madraktype=madraktype, anbarcode = anbarcode});

        }

        [HttpPost]
        public ActionResult madrak_update(TMad myModel)
        {
            int m = 0;
            

            if (ModelState.IsValid)
            {
                string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

                try
                {


                    if (myModel.MadrakCode == 0)
                    {
                        int mm = 0;
                        try
                        {
                            mm = db.TMad.Where(a => a.MadrakType == myModel.MadrakType & a.MadrakActive == 1 & a.SalMali == strSalMali & a.AnbarCode == myModel.AnbarCode).Max(a => a.MadrakCode);
                        }
                        catch (Exception ex)
                        {

                        }

                        mm++;
                        myModel.MadrakCode = mm;

                        myModel.MadrakActive = 1;
                        myModel.SalMali = strSalMali;

                        db.TMad.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }


                    m = db.SaveChanges();

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/AnbarGardani/Madrak?madraktype="+myModel.MadrakType+"&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
                }
                catch (Exception ex)
                {
                    string strMessage = ErrorHandler.GetErrorMessage(ex);

                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
                }


            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
        }

        public ActionResult madrakItem_update(int anbarcode=0, int madrakcode=0, int madrakradif=0, int kalacode=0, int markazcode=0, double tedad=-1, byte madraktype = 0)
        {
            int m = 0;
            TMadItm myModel = new TMadItm { MadrakType = madraktype, AnbarCode = anbarcode, MadrakCode = madrakcode, MadrakRadif = madrakradif, KalaCode = kalacode, MarkazCode = markazcode, Tedad = tedad };
                


                string strSalMali = db.TCurrent.FirstOrDefault().SalMali;

            try
            {

                if (myModel.AnbarCode == 0)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "انبار انتخاب نشده است", BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
                }

                if (myModel.MadrakCode == 0)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "کد موجودی انتخاب نشده است", BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
                }

                if (myModel.KalaCode == 0)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "کالا انتخاب نشده است", BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
                }

                if (myModel.Tedad == -1)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "تعداد/مقدار موجود وارد نشده است", BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
                }

                if (myModel.MadrakRadif == 0)
                {
                    int mm = 0;
                    try
                    {
                        mm = db.TMadItm.Where(a => a.MadrakType == madraktype & a.AnbarCode == myModel.AnbarCode & a.MadrakCode==myModel.MadrakCode).Max(a => a.MadrakRadif);
                    }
                    catch (Exception ex)
                    {

                    }

                    mm++;
                    myModel.MadrakRadif = mm;

                    myModel.SalMali = strSalMali;

                    db.TMadItm.Add(myModel);
                }
                else
                {
                    db.Entry(myModel).State = EntityState.Modified;
                }


                m = db.SaveChanges();

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "success", Title = "موفقیت", SubTitle = "", MessageBody = "ذخیره‌سازی با موفقیت انجام شد", BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
            }
            catch (Exception ex)
            {
                string strMessage = ErrorHandler.GetErrorMessage(ex);

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
            }

            //return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = "مقادیر ورودی نامعتبرند", BackUrl = "~/AnbarGardani/Madrak?anbarcode=" + myModel.AnbarCode.ToString() + "&madrakcode=" + myModel.MadrakCode.ToString() });
        }

        public ActionResult madrakItem_Delete(int anbarcode = 0, int madrakcode = 0, int madrakradif = 0, byte madraktype = 0)
        {
            TMadItm myModel = new TMadItm { MadrakType = madraktype, AnbarCode = anbarcode, MadrakCode = madrakcode, MadrakRadif = madrakradif };

            try
            {
                TMadItm myItem = db.TMadItm.Where(m => m.MadrakType == madraktype & m.AnbarCode == anbarcode & m.MadrakCode == madrakcode & m.MadrakRadif==madrakradif).First();

                if (myItem!= null)
                {
                    db.TMadItm.Remove(myItem);
                    db.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                string strMessage = ErrorHandler.GetErrorMessage(ex);

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strMessage, BackUrl = "~/AnbarGardani/Madrak?madraktype=" + myModel.MadrakType + "&anbarcode=" + anbarcode.ToString() + "&madrakcode=" + madrakcode.ToString() });
            }


            return RedirectToAction("Madrak", routeValues: new { anbarcode = anbarcode, madrakcode=madrakcode, madraktype=madraktype });


        }


    }
}