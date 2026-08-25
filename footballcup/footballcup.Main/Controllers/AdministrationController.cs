using CommonUnit;
using footballcup.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace footballcup.Controllers
{
    public class AdministrationController : Controller
    {

        footballcupDbContext db = new footballcupDbContext();
        public ActionResult Cup()
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                Cup myCup = new Cup();

                ViewBag.CupList = db.Cup.ToList();

                try
                {
                    myCup = db.Cup.Where(c => c.IsDefaultCup == true).FirstOrDefault();
                    if (myCup == null)
                        myCup = db.Cup.FirstOrDefault();
                    if (myCup == null)
                        myCup = new Cup();
                }
                catch (Exception ex)
                {

                }

                int cupid = myCup.CupId;

                List<CupTeamView> myCupTeam = (from ct in db.CupTeam
                                               join t in db.Team on ct.TeamId equals t.TeamId into g1
                                               from tct in g1.DefaultIfEmpty()
                                               select new CupTeamView
                                               {
                                                   CupId = ct.CupId
                                                   ,
                                                   TeamId = ct.TeamId
                                                   ,
                                                   TeamPName = tct.PName
                                                   ,
                                                   con = tct.con
                                                   //}).Where(a => a.CupId == cupid).ToList();
                                               }).ToList();
                myCupTeam.Add(new CupTeamView() { TeamId = 0, TeamPName = "" });
            ViewBag.TeamList = myCupTeam;

                return View(myCup);
            }

            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Cup_Update(HttpPostedFileBase ImageUrlUpload, Cup myCup)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                string strFilename = "";

                if (myCup.CupId == 0)
                {
                    ///جدید

                    db.Cup.Add(myCup);
                    int n = db.SaveChanges();

                    //int mmm = db.Entry(myUser).Entity.UserId;
                }

                try
                {
                    myCup.PhotoFileName = myCup.LName.ToString() + ".png";
                    db.Entry(myCup).State = System.Data.Entity.EntityState.Modified;

                    int n = db.SaveChanges();

                    if (ImageUrlUpload != null)
                    {

                        try
                        {

                            strFilename = Path.Combine(Server.MapPath("~/temp/"), ImageUrlUpload.FileName);
                            Helper.UploadFile(ImageUrlUpload, strFilename);
                            byte[] myImafeBuffer = Helper.GetImage(strFilename, System.Drawing.Imaging.ImageFormat.Png);

                            Helper.SaveImage(myImafeBuffer, Path.Combine(Server.MapPath("~/assets/images/cup/"), myCup.LName.ToString() + ".png"), System.Drawing.Imaging.ImageFormat.Png);
                            //Helper.SaveImage(myImafeBuffer, Path.Combine(Server.MapPath("~/assets/images/"), myCup.LName.ToString() + ".png"), System.Drawing.Imaging.ImageFormat.Png);

                        }

                        catch (Exception ex)
                        {

                            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "", SubTitle = "توجه:", MessageBody = ex.Message, BackUrl = "~/Administration/Cup" });
                            //Response.Redirect("http://www.google.com/" + ex.Message);
                        }
                    }


                    

                    if (myCup.IsDefaultCup)
                    {
                        string strQuery = string.Format("update Cup set IsDefaultCup ={0} where CupId<> {1} ", 0, myCup.CupId);
                        int m = db.Database.ExecuteSqlCommand(strQuery);
                    }
                }

                catch (Exception ex)
                {
                    string strRes = MessageModel.GetErrorMessage(ex);
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Administration/Cup" });
                }

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Success", Title = "موفقیت", SubTitle = "توجه:", MessageBody = "مشخصات جام اصلاح شد", BackUrl = "~/Administration/Cup" });
            }

            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        [AllowAnonymous]
        public ActionResult SelectCup(int cupid)
        {
            Cup result = new Cup();
            string con1 = "", con2 = "", con3 = "";

            try
            {
                result = db.Cup.Where(c => c.CupId == cupid).FirstOrDefault();
                con1 = db.Team.Where(t => t.TeamId == result.Team1).FirstOrDefault().con;
                con2 = db.Team.Where(t => t.TeamId == result.Team2).FirstOrDefault().con;
                con3 = db.Team.Where(t => t.TeamId == result.Team3).FirstOrDefault().con;
            }
            catch
            {

            }

            


            return Json(new { result , con1,con2,con3}, JsonRequestBehavior.AllowGet);
        }

        /*************************************************************/


        //[Authorize(Roles = "Admin, Super User")]
        public ActionResult CupTeam(int cupid = 0)
        {
            //if (Request.IsAuthenticated)
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                ViewBag.TeamList = db.Team.ToList();
                ViewBag.CupList = db.Cup.ToList();


                Cup myCup = new Cup();


                try
                {
                    if (cupid == 0)
                        myCup = db.Cup.Where(c => c.IsDefaultCup == true).FirstOrDefault();
                    else
                        myCup = db.Cup.Where(c => c.CupId == cupid).FirstOrDefault();

                    if (myCup == null)
                        myCup = db.Cup.FirstOrDefault();
                    if (myCup == null)
                        myCup = new Cup();
                    else
                        cupid = myCup.CupId;

                }
                catch (Exception ex)
                {

                }

                ViewBag.Cup = myCup;

                List<CupTeamView> myCupTeam = (from t in db.Team
                                               join ct in db.CupTeam.Where(a => a.CupId == cupid) on t.TeamId equals ct.TeamId into g1
                                               from tct in g1.DefaultIfEmpty()
                                               select new CupTeamView
                                               {
                                                   Id = (tct == null) ? 0 : tct.Id,
                                                   CupId = (tct == null) ? 0 : tct.CupId
                                                   ,
                                                   TeamId = t.TeamId
                                                   ,
                                                   TeamPName = t.PName
                                                   ,
                                                   con = t.con
                                                   ,
                                                   TeamRank = (tct == null) ? 0 : tct.TeamRank
                                                   ,
                                                   selected = (tct != null)
                                                   ,
                                                   TeamLName = t.LName
                                               }).ToList();
                //  }).Where(g1=>g1.CupId == cupid).ToList();

                //  ViewBag.CupTeamList = myCupTeam;

                return View(myCupTeam);
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }


        [AllowAnonymous]
        public ActionResult CupTeam_Update(List<CupTeamView> cupteamlist, int cupid)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                try
                {

                    foreach (CupTeamView item in cupteamlist)
                    {
                        CupTeam myCupTeam = new Models.CupTeam();

                        myCupTeam.Id = item.Id;

                        if (item.selected)
                        {
                            if (item.Id == 0)
                            {
                               
                                myCupTeam.CupId = cupid;
                                myCupTeam.TeamId = item.TeamId;
                                myCupTeam.TeamRank = item.TeamRank;
                                db.CupTeam.Add(myCupTeam);
                            }
                            else
                            {
                                int m = item.Id;
                                myCupTeam = db.CupTeam.Where(c => c.Id == m).FirstOrDefault();
                                myCupTeam.CupId = cupid;
                                myCupTeam.TeamId = item.TeamId;
                                myCupTeam.TeamRank = item.TeamRank;
                                myCupTeam.Id = item.Id;
                                db.Entry(myCupTeam).State = System.Data.Entity.EntityState.Modified;
                            }
                        }
                        else if (item.Id != 0)
                        {
                            int m = item.Id;
                            myCupTeam = db.CupTeam.Where(c => c.Id == m).FirstOrDefault();
                            db.CupTeam.Remove(myCupTeam);
                        }


                    }


                    int n = db.SaveChanges();

                }
                catch (Exception ex)
                {

                }

                return RedirectToAction("CupTeam", new { cupid = cupid });
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }

        }
        /*************************************************************/

        [AllowAnonymous]
        public ActionResult Competitor(int cupid = 0)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                ViewBag.TeamList = db.Team.ToList();
                ViewBag.CupList = db.Cup.ToList();

                if (cupid == 0)
                    cupid = ((Cup)(Session[CommonUnit.GlobalModule.m_CurrentCup])).CupId;


                List<CompetitorView> myCompetitor = (from u in db.AppUser
                                               join cu in db.Competitor.Where(cu => cu.CupId == cupid) on u.UserId equals cu.CompetitorId into t1
                                               from t11 in t1.DefaultIfEmpty()
                                               join c in db.Cup on t11.CupId equals c.CupId into t2
                                               from t21 in t2.DefaultIfEmpty()
                                               select new CompetitorView
                                               {
                                                   CompetitorId =  u.UserId ,
                                                  // UserId = u.UserId,
                                                   LoginName = u.LoginName,
                                                   CompetitorName = u.UserDs,
                                                   UserRole=u.UserRole,
                                                   ThumbnailPhoto = u.ThumbnailPhoto,
                                                   CupId = (t11 == null) ? 0 : t11.CupId,
                                                   CupPName = (t11 == null) ? "" : t21.PName,
                                                   RegDate = (t11 == null) ? new DateTime(1, 1, 1) : t11.RegDate
                                                   ,
                                                   RegStatus = (t11 == null) ? (byte)0 : t11.RegStatus
                                                   ,
                                                   selected = (t11 != null)
                                                   ,
                                                   ParticipantType = (t11 == null) ? (byte)0 : t11.ParticipantType


                                                   , PredictDate= (t11 == null) ? DateTime.Now : t11.PredictDate

                                                   , Team1= (t11 == null) ? 0 : t11.Team1
                                                   ,
                                                   Team2 = (t11 == null) ? 0 : t11.Team2
                                                   ,
                                                   Team3 = (t11 == null) ? 0 : t11.Team3
                                                   ,
                                                   InitialPoint = (t11 == null) ? 0 : t11.InitialPoint
                                                   ,
                                                   TotalPredictionsPoint = (t11 == null) ? 0 : t11.TotalPredictionsPoint
                                                   , SpecialPoint = (t11 == null) ? 0 : t11.SpecialPoint
                                                   ,
                                                   ModifyTime = (t11 == null) ? DateTime.Now : t11.ModifyTime


                                               }).ToList();


                Cup myCup = new Cup();


                try
                {
                    if (cupid == 0)
                        myCup = db.Cup.Where(c => c.IsDefaultCup == true).FirstOrDefault();
                    else
                        myCup = db.Cup.Where(c => c.CupId == cupid).FirstOrDefault();


                    if (myCup == null)
                        myCup = db.Cup.FirstOrDefault();
                    if (myCup == null)
                        myCup = new Cup();
                    else
                        cupid = myCup.CupId;

                }
                catch (Exception ex)
                {

                }

                ViewBag.Cup = myCup;

                //ViewBag.ParticipantTypeList = new List<Prime> { new Prime() { Id = 0, Title = "مجازی" }, new Prime() { Id = 1, Title = "حقیقی" } };
                return View(myCompetitor);
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }



        [AllowAnonymous]
        public ActionResult Competitor_Update(List<CompetitorView> Competitorlist, int cupid)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                try
                {
                    db.Competitor.RemoveRange(db.Competitor.Where(m => m.CupId == cupid ).ToList());

                    List<CompetitorView> newCompetitorList = Competitorlist.Where(m => m.selected == true ).ToList();

                    foreach (CompetitorView item in newCompetitorList)
                    {
                        Competitor myCompetitor = new Models.Competitor();
                        
                        myCompetitor.CupId = cupid;
                        myCompetitor.RegStatus = 1;
                        myCompetitor.CompetitorId = item.CompetitorId;
                        myCompetitor.RegDate = DateTime.Today;
                        myCompetitor.ParticipantType = item.ParticipantType;

                        myCompetitor.Team1 = item.Team1;
                        myCompetitor.Team2 = item.Team2;
                        myCompetitor.Team3 = item.Team3;
                        myCompetitor.TotalPredictionsPoint = item.TotalPredictionsPoint;
                        myCompetitor.InitialPoint = item.InitialPoint;
                        myCompetitor.SpecialPoint = item.SpecialPoint;
                        myCompetitor.ModifyTime = item.ModifyTime;
                        myCompetitor.PredictDate = item.PredictDate;


                        db.Competitor.Add(myCompetitor);
                    }


                    int n = db.SaveChanges();

                }
                catch (Exception ex)
                {

                }

                return RedirectToAction("Competitor", new { cupid = cupid });
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        /*************************************************************/

        [AllowAnonymous]
        public ActionResult cms(int cupid = 0)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                Cup myCup = new Cup();

                ViewBag.CupList = db.Cup.ToList();

                try
                {
                    if (cupid == 0)
                        myCup = db.Cup.Where(c => c.IsDefaultCup == true).FirstOrDefault();
                    else
                        myCup = db.Cup.Where(c => c.CupId == cupid).FirstOrDefault();


                    if (myCup == null)
                        myCup = db.Cup.FirstOrDefault();
                    if (myCup == null)
                        myCup = new Cup();
                    else
                        cupid = myCup.CupId;

                    //string myPattern = myCup.LName + "_*.*";
                    //var myList = Directory.GetFiles(Server.MapPath("~/assets/images/gallery/"),myPattern);
                    var myList = db.Cms.Where(m => m.CupId == cupid && m.IsChat == false).ToList();
                    ViewBag.CmsList = myList.ToList();
                    ViewBag.Cup = myCup;
                }
                catch (Exception ex)
                {

                }

                return View(myCup);
            }

            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        public ActionResult cms_Update(int cupid, int cmsid = 0)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                Cms myCms = new Cms();

                myCms = db.Cms.Where(c => c.CmsId == cmsid).FirstOrDefault();

                if (myCms == null)
                {
                    myCms = new Cms();
                    myCms.CmsId = 0;
                }

                return View(myCms);
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult cms_Update(HttpPostedFileBase ImageUrlUpload, Cms myCms)
        {
            string strRes = "";

            try
            {
                if (ImageUrlUpload != null)
                {

                    try
                    {
                        string strServerFileName = Path.Combine(Server.MapPath("~/temp/"), ImageUrlUpload.FileName);
                        string strFileName = ImageUrlUpload.FileName.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries)[0] + ".jpg";
                        Helper.UploadFile(ImageUrlUpload, strServerFileName);
                        byte[] myImafeBuffer = Helper.GetImage(strServerFileName, System.Drawing.Imaging.ImageFormat.Png);
                        Helper.SaveImage(myImafeBuffer, Path.Combine(Server.MapPath("~/assets/images/gallery/"), strFileName), System.Drawing.Imaging.ImageFormat.Jpeg);

                        myCms.PictureFile = strFileName;


                    }
                    catch (Exception ex)
                    {
                        return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "", SubTitle = "توجه:", MessageBody = ex.Message, BackUrl = "~/Administration/cms_update" });
                    }
                }

                if (myCms.CupId == 0)
                {
                    myCms.CupId = ((Cup)(Session[CommonUnit.GlobalModule.m_CurrentCup])).CupId;
                }

                if (myCms.CmsId == 0)
                {
                    myCms.PublishDate = DateTime.Now;
                    if (myCms.AuthorId == 0)
                        myCms.AuthorId = ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId;

                    db.Cms.Add(myCms);
                }
                else
                {
                    db.Entry(myCms).State = System.Data.Entity.EntityState.Modified;
                }

                int n = db.SaveChanges();
                /*
                   string myPattern = myCms.CupId + "_*.*";
                   var myList = Directory.GetFiles(Server.MapPath("~/assets/images/gallery/"), myPattern);


                   int maxid = 0;
                   try {
                       string ff = myList.Max().Split(new string[] { myCms.CmsId + "_" }, StringSplitOptions.None)[1].Split(new string[] { ".jpg"}, StringSplitOptions.RemoveEmptyEntries)[0];
                           maxid = Convert.ToInt32(ff);
                   }
                   catch
                   {

                   }
                   maxid++;
                   */




            }
            catch (Exception ex)
            {
                strRes = "ERROR:" + ex.Message.ToString();
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Administration/cms" });
            }

            return RedirectToAction("cms");

        }

        [AllowAnonymous]
        public ActionResult cms_Delete(int cmsid)
        {
            Cms myCms;
            string strRes = "";
            string strFilename = "";

            try
            {
                myCms = db.Cms.Where(t => t.CmsId == cmsid).FirstOrDefault();



                db.Cms.Remove(myCms);
                int n = db.SaveChanges();

                try
                {
                    strFilename = Path.Combine(Server.MapPath("~/assets/images/gallery/"), myCms.PictureFile);
                    System.IO.File.Delete(strFilename);
                }
                catch
                {

                }
            }

            catch (Exception ex)
            {
                strRes = "ERROR:" + ex.Message.ToString();
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Administration/cms" });
            }

            return RedirectToAction("cms");

        }

        /////////////////
        
        [AllowAnonymous]
        public ActionResult Notification(int cmsid = 0)
        {
            int cupid = ((Cup)(Session[CommonUnit.GlobalModule.m_CurrentCup])).CupId;

            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST)
            {
                int uid = ((AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;

                try
                {
                    List<Cms> myList;
                    if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
                    {
                        myList = db.Cms.Where(m => m.CupId==cupid && m.IsMessage == true).ToList();
                    }
                    else
                    {
                        myList = db.Cms.Where(m => m.CupId == cupid && m.IsMessage == true && (m.TargetReceiver == 0 || m.TargetReceiver == uid || m.AuthorId == uid)).ToList();
                    }

                    ViewBag.NotificationList = myList.Join(db.AppUser, c => c.AuthorId, a => a.UserId, (c, a) => new CmsView { CmsId = c.CmsId, Title = c.Title, Body = c.Body, AuthorId = c.AuthorId, IsActive = c.IsActive, IsChat = c.IsChat, IsSlider = c.IsSlider, IsMessage = c.IsMessage, TargetReceiver = c.TargetReceiver, ReadStatus = c.ReadStatus, ParentCmsId = c.ParentCmsId, IsHotNews = c.IsHotNews, PublishDate = c.PublishDate, PictureFile = c.PictureFile, AuthorDs = a.UserDs, AuthorThumbnail = a.ThumbnailPhoto }).ToList();
                }
                catch
                {

                }


                ViewBag.UserList = db.AppUser.ToList();

                Cms myCms = new Cms();

                try
                {
                    if (cmsid == 0)
                    {
                        myCms.CmsId = 0;
                        myCms.AuthorId = uid;
                        myCms.IsMessage = true;
                        myCms.IsActive = true;
                    }
                    else
                        myCms = db.Cms.Where(c => c.CmsId == cmsid).FirstOrDefault();
                }
                catch
                {

                }

                return View(myCms);
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult Notification_Update(Cms myCms)
        {
            string strRes = "";

            try
            {
                myCms.IsMessage = true;
                myCms.CupId= ((Cup)(Session[CommonUnit.GlobalModule.m_CurrentCup])).CupId;

                if (myCms.AuthorId == 0)
                    myCms.AuthorId = ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId;

                if (myCms.AuthorId != ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId && ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.ADMIN)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "عدم مجوز اصلاح", MessageBody = "نمی‌توانید پیام دیگران را بروزرسانی کنید", BackUrl = "~/Administration/notification" });
                }

                if (myCms.CmsId == 0)
                {
                    myCms.PublishDate = DateTime.Now;
                    db.Cms.Add(myCms);
                }
                else
                {
                    db.Entry(myCms).State = System.Data.Entity.EntityState.Modified;
                }

                int n = db.SaveChanges();




            }
            catch (Exception ex)
            {
                strRes = "ERROR:" + ex.Message.ToString();
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Administration/Notification" });
            }

            return RedirectToAction("Notification");
        }

        [AllowAnonymous]
        public ActionResult Notification_Delete(int cmsid)
        {
            Cms myCms;
            string strRes = "";

            
            if (((AppUserView)Session[GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.GUEST)
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "عدم مجوز حذف", MessageBody = "شما اجازه حذف ندارید", BackUrl = "~/Administration/notification" });
            }

            try
            {
                myCms = db.Cms.Where(t => t.CmsId == cmsid).FirstOrDefault();



                db.Cms.Remove(myCms);
                int n = db.SaveChanges();


            }

            catch (Exception ex)
            {
                strRes = "ERROR:" + ex.Message.ToString();
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Administration/Notification" });
            }

            return RedirectToAction("Notification");

        }


        //
        [AllowAnonymous]
        public ActionResult Notification_UpdateReadStatus(int cmsid, int authorid, int targetid)
        {
            string strRes = "";

            try
            {


                //if (authorid != ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId && targetid != 0)
                if (targetid == ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId && targetid != 0)
                {

                    if (cmsid != 0)
                    {
                        Cms myCms = new Cms();
                        myCms = db.Cms.Where(c => c.CmsId == cmsid).FirstOrDefault();
                        if (myCms.ReadStatus == 0)
                            myCms.ReadStatus = 1;
                        else
                            myCms.ReadStatus = 0;

                        db.Entry(myCms).State = System.Data.Entity.EntityState.Modified;
                    }

                    int n = db.SaveChanges();

                }


            }
            catch (Exception ex)
            {
                strRes = "ERROR:" + ex.Message.ToString();
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Administration/Notification" });
            }

            return RedirectToAction("Notification");
        }


    }
}