using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using footballcup.Models;
using CommonUnit;
using System.Drawing;
using System.IO;

namespace footballcup.Controllers
{
    public class HomeController : Controller
    {
        footballcupDbContext db = new footballcupDbContext();
        public ActionResult Index()
        {
            int cupid = 0;
            List<Match> myMatches = new List<Match>();
            List<MatchView> my4EndedMatches = new List<MatchView>();
            List<PredictionView> my4UpcomingMatches = new List<PredictionView>();
                                  
            List<Cms> myCmsList = new List<Cms>();

            try
            {
                /// for database building
                cupid = ((footballcup.Models.Cup)Session[CommonUnit.GlobalModule.m_CurrentCup]).CupId;
            }
            catch
            {
                cupid = 0;
            }

            int uid = ((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;


            try
            {

                myCmsList = db.Cms.Where(m =>  m.IsActive == true && m.CupId==cupid).ToList();

                //string myPattern = ((Cup)Session[GlobalModule.m_CurrentCup]).LName+"_*.*";
                //var myList = Directory.GetFiles(Server.MapPath("~/assets/images/gallery/"), myPattern);

                ViewBag.CmsList = myCmsList.Join(db.AppUser, c => c.AuthorId, a => a.UserId, (c, a) => new CmsView { CmsId = c.CmsId, CupId = c.CupId, Title = c.Title, Body = c.Body, AuthorId = c.AuthorId, IsActive = c.IsActive, IsChat = c.IsChat, IsSlider = c.IsSlider, ReadStatus = c.ReadStatus, ParentCmsId = c.ParentCmsId, IsHotNews = c.IsHotNews, PublishDate = c.PublishDate, PictureFile = c.PictureFile, AuthorDs = a.UserDs, AuthorThumbnail = a.ThumbnailPhoto }).ToList(); 


                if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST)
                {
                    try
                    {

                        List<Cms> myList2 = myCmsList.Where(m => m.IsMessage == true && m.IsActive == true && m.ReadStatus == 0 && (m.TargetReceiver == 0 || m.TargetReceiver == uid)).OrderByDescending(m => m.CmsId).ToList();
                        Session[GlobalModule.m_NotificationCount] = myList2.Count;
                        myList2 = myList2.Take(4).ToList();
                        Session[GlobalModule.m_NotificationList] = myList2.Join(db.AppUser, c => c.AuthorId, a => a.UserId, (c, a) => new CmsView { CmsId = c.CmsId, Title = c.Title, Body = c.Body, AuthorId = c.AuthorId, IsActive = c.IsActive, IsChat = c.IsChat, IsSlider = c.IsSlider, IsMessage = c.IsMessage, TargetReceiver = c.TargetReceiver, ReadStatus = c.ReadStatus, ParentCmsId = c.ParentCmsId, IsHotNews = c.IsHotNews, PublishDate = c.PublishDate, PictureFile = c.PictureFile, AuthorDs = a.UserDs, AuthorThumbnail = a.ThumbnailPhoto }).ToList();

                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception ex)
            {

            }

            try
            {
                int u1 = ((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;


               myMatches = db.Match.OrderBy(m => m.MatchTime).Where(m => (m.CupId == cupid) && m.MatchState == 0 || m.MatchState == 2).Take(4).ToList();

                my4UpcomingMatches = (from m in myMatches
                                                           join t1 in db.Team on m.Team1Id equals t1.TeamId into g1
                                                           from mt1 in g1.DefaultIfEmpty()
                                                           join t2 in db.Team on m.Team2Id equals t2.TeamId into g2
                                                           from mt2 in g2.DefaultIfEmpty()
                                                          
                                                           join p in db.Prediction.Where(a => a.CompetitorId==u1) on m.MatchId equals p.MatchId into g3
                                                           from mt3 in g3.DefaultIfEmpty()
                                                           select new PredictionView
                                                           {
                                                               MatchId = m.MatchId,
                                                               MatchTime = m.MatchTime,
                                                               MatchCoefficient = m.MatchCoefficient,
                                                               MatchState = m.MatchState,
                                                               CupId = m.CupId,
                                                               Team1Id = m.Team1Id,
                                                               Team1PName = mt1.PName,
                                                               con1 = mt1.con,
                                                               Team2Id = m.Team2Id,
                                                               Team2PName = mt2.PName,
                                                               con2 = mt2.con
                                                         ,
                                                               CompetitorId = mt3?.CompetitorId ?? 0
                                                         ,
                                                               Team1Guess = mt3?.Team1Guess
                                                         ,
                                                               Team2Guess = mt3?.Team2Guess 
                                                         ,
                                                               PredictId = mt3?.PredictId ??0
                                                           }).ToList();


               
            }

            catch (Exception ex)
            {

            }

            try
            {
                myMatches = db.Match.OrderByDescending(m => m.MatchTime).Where(m => (m.CupId == cupid) && m.MatchState == 1).Take(4).ToList();
                my4EndedMatches = (from m in myMatches
                                      join t1 in db.Team on m.Team1Id equals t1.TeamId into g1
                                      from mt1 in g1.DefaultIfEmpty()
                                      join t2 in db.Team on m.Team2Id equals t2.TeamId into g2
                                      from mt2 in g2.DefaultIfEmpty()
                                      select new MatchView
                                      {
                                          MatchId = m.MatchId,
                                          MatchTime = m.MatchTime,                                    
                                          MatchState = m.MatchState,
                                          CupId = m.CupId,
                                          Team1Id = m.Team1Id,
                                          Team1PName = mt1.PName,
                                          con1 = mt1.con,
                                          Team2Id = m.Team2Id,
                                          Team2PName = mt2.PName,
                                          con2 = mt2.con
                                          ,Team1Score=m.Team1Score
                                          ,
                                          Team2Score = m.Team2Score
                                          ,MatchCoefficient=m.MatchCoefficient

                                      }).ToList();
                

            }
            catch (Exception ex)
            {

            }

       



            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.GUEST)
            {
                ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserDs = "ورود/ثبت‌نام";
                ((AppUserView)Session[GlobalModule.m_CurrentUser]).ThumbnailPhotoFileName = "assets/images/person/avatar3.png";
            }
            else
            {

            }

            ViewBag.MatchList_4Upcoming = my4UpcomingMatches;
            ViewBag.MatchList_4Ended = my4EndedMatches;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
            // return View("testview");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";



            //List<Tuple<byte, string>> m = new List<Tuple<byte, string>> { new Tuple<byte, string>( 0,  "مجازی"), new Tuple<byte, string>( 1,  "حقیقی") };

            return View();
        }


        public ActionResult TestView(int cmsid = 0)
        {

          
                int uid = ((AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;

                try
                {
                    List<Cms> myList;
                    if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
                    {
                        myList = db.Cms.Where(m => m.IsMessage == true).ToList();
                    }
                    else
                    {
                        myList = db.Cms.Where(m => m.IsMessage == true && (m.TargetReceiver == 0 || m.TargetReceiver == uid || m.AuthorId == uid)).ToList();
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

        /*************************************************************/

        public ActionResult HandleMessage(MessageModel myModel)
        {
            if (myModel.ShowMessagePlace == 1)
                return View("MessageView", myModel);
            else
                return View("MessageView", myModel);
        }





    }
}