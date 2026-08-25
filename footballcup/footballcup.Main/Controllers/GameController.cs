using CommonUnit;
using footballcup.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace footballcup.Controllers
{
    public class GameController : Controller
    {
        footballcupDbContext db = new footballcupDbContext();



        /*************************************************************/


        [AllowAnonymous]
        public ActionResult Match(int cupid = 0)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                ViewBag.UPDATEFLAG = 1;
            }
            else
            {
                ViewBag.UPDATEFLAG = 0;
                // return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }

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

            ViewBag.CupList = db.Cup.ToList();

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
                                           }).Where(a => a.CupId == cupid).ToList();

            ViewBag.TeamList = myCupTeam;

            List<MatchView> myMatches = (from m in db.Match
                                         join t1 in db.Team on m.Team1Id equals t1.TeamId into g1
                                         from mt1 in g1.DefaultIfEmpty()
                                         join t2 in db.Team on m.Team2Id equals t2.TeamId into g2
                                         from mt2 in g2.DefaultIfEmpty()
                                         select new MatchView
                                         {
                                             MatchId = m.MatchId,
                                             MatchNo = m.MatchNo,
                                             MatchTime = m.MatchTime,
                                             GroupName = m.GroupName,
                                             MatchCoefficient = m.MatchCoefficient,
                                             MatchState = m.MatchState,
                                             CupId = m.CupId,
                                             Team1Id = m.Team1Id,
                                             Team1PName = mt1.PName,
                                             con1 = mt1.con,
                                             Team1Score = m.Team1Score,
                                             Team2Id = m.Team2Id,
                                             Team2PName = mt2.PName,
                                             con2 = mt2.con,
                                             Team2Score = m.Team2Score

                                         }).Where(m => m.CupId == cupid).OrderBy(m => m.MatchTime).ToList();

            ViewBag.MatchList = myMatches;
            ViewBag.Cup = myCup;

            return View();

        }

        [AllowAnonymous]
        public ActionResult Match_Update(Match myMatch)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }

            try
            {
                myMatch.UserId = ((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;
                myMatch.ModifyTime = DateTime.Now;

                if (myMatch.MatchId == 0)
                {

                    db.Match.Add(myMatch);
                }
                else
                {

                    db.Entry(myMatch).State = System.Data.Entity.EntityState.Modified;
                }

                int n = db.SaveChanges();
            }

            catch (Exception ex)
            {
                string strRes = MessageModel.GetErrorMessage(ex);
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Game/match" });
            }


            return RedirectToAction("Match", "Game", routeValues: new { @cupid = myMatch.CupId });

        }

        [AllowAnonymous]
        public ActionResult Match_Delete(int matchid)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                Match myMatch = new Match();

                try
                {
                    myMatch = db.Match.Where(t => t.MatchId == matchid).FirstOrDefault();
                    db.Match.Remove(myMatch);
                    int n = db.SaveChanges();
                }

                catch (Exception ex)
                {
                    string strRes = MessageModel.GetErrorMessage(ex);
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Game/match" });
                }


                return RedirectToAction("Match", "Game");
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        /*************************************************************/
        //[AllowAnonymous]
        //public ActionResult Prediction()
        //{
        //    Competitor cu = new Competitor();

        //    if (((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.ADMIN )
        //    {
        //        try
        //        {
        //            int u1, c1;

        //            u1 = ((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;
        //            c1 = ((Cup)Session[GlobalModule.m_CurrentCup]).CupId;
        //            //cu = db.Competitor.Where(c => c.UserId == ((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId && c.CupId == ((Cup)Session[GlobalModule.m_CurrentCup]).CupId).FirstOrDefault();
        //            //cu = db.Competitor.Where(c => c.UserId == 6 && c.CupId == 1).FirstOrDefault();
        //            cu = db.Competitor.Where(c => c.CompetitorId == u1 && c.CupId == c1).FirstOrDefault();
        //        }
        //        catch (Exception ex)
        //        {
        //            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
        //        }
        //    }

        //    if (((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST && cu != null)
        //    {

        //        List<PredictionView> myPredictionList;

        //        if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
        //            myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0}, @matchstate=0", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId }).OrderBy(m => m.MatchTime).OrderBy(m => m.MatchTime).ToList();
        //        else
        //            myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0}, @competitorid = {1}, @matchstate=0", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId, cu.CompetitorId }).OrderBy(m => m.MatchTime).ToList();

        //        ViewBag.PredictionList = myPredictionList;


        //        return View();
        //    }
        //    else
        //    {
        //        return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
        //    }
        //}

        [AllowAnonymous]
        public ActionResult Prediction()
        {
            Competitor cu = new Competitor();

            if (((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.ADMIN)
            {
                try
                {
                    int u1, c1;

                    u1 = ((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;
                    c1 = ((Cup)Session[GlobalModule.m_CurrentCup]).CupId;
                    //cu = db.Competitor.Where(c => c.UserId == ((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId && c.CupId == ((Cup)Session[GlobalModule.m_CurrentCup]).CupId).FirstOrDefault();
                    //cu = db.Competitor.Where(c => c.UserId == 6 && c.CupId == 1).FirstOrDefault();
                    cu = db.Competitor.Where(c => c.CompetitorId == u1 && c.CupId == c1).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
                }
            }

            if (((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST && cu != null)
            {

                List<PredictionView> myPredictionList;

                if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN)
                    myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0}, @matchstate=0", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId }).OrderBy(m => m.MatchTime).OrderBy(m => m.MatchTime).ToList();
                else
                    myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0}, @competitorid = {1}, @matchstate=0", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId, cu.CompetitorId }).OrderBy(m => m.MatchTime).ToList();

                ViewBag.PredictionList = myPredictionList;


                return View(myPredictionList);
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }


        [AllowAnonymous]
        public ActionResult Prediction_Update(string backurl, PredictionView pv)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST)
            {
                Prediction myPrediction = new Prediction();

                try
                {
                    myPrediction = db.Prediction.Where(p => p.PredictId == pv.PredictId).FirstOrDefault();


                    //System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
                    //System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    //System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
                    DateTime pt1 = DateTime.Now;
                    //System.Globalization.PersianCalendar j = new System.Globalization.PersianCalendar();                    
                    //DateTime r = new DateTime();
                    //r = pv.MatchTime;
                    //r =DateTime.Parse(pt1.ToLongDateString());


                    //if ((pv.MatchTime - pt1).TotalSeconds > 300)
                    if ((pv.MatchTime - pt1).TotalSeconds >= 0)
                    {

                        if (myPrediction == null)
                        {
                            myPrediction = new Prediction();

                            myPrediction.MatchId = pv.MatchId.Value;
                            myPrediction.Team1Guess = pv.Team1Guess;
                            myPrediction.Team2Guess = pv.Team2Guess;
                            myPrediction.CompetitorId = pv.CompetitorId.Value;
                            myPrediction.PredictTime = DateTime.Now;
                            myPrediction.ShowPrediction = pv.ShowPrediction;
                            myPrediction.UserId = ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId;
                            myPrediction.ModifyTime = DateTime.Now;
                            myPrediction.CompetitorMatchPoint = 0;
                            db.Prediction.Add(myPrediction);
                        }
                        else
                        {
                            myPrediction.MatchId = pv.MatchId.Value;
                            myPrediction.Team1Guess = pv.Team1Guess;
                            myPrediction.Team2Guess = pv.Team2Guess;
                            myPrediction.CompetitorId = pv.CompetitorId.Value;
                            myPrediction.PredictTime = DateTime.Now;
                            myPrediction.ShowPrediction = pv.ShowPrediction;
                            myPrediction.UserId = ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId;
                            myPrediction.ModifyTime = DateTime.Now;
                            myPrediction.CompetitorMatchPoint = 0;


                            db.Entry(myPrediction).State = System.Data.Entity.EntityState.Modified;
                        }

                        int n = db.SaveChanges();
                    }
                    else
                    {
                        return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "عدم مجوز پیش‌بینی", MessageBody = "تاریخ مجاز پیش‌بینی گذشته و یا بازی بسته شده است", BackUrl = backurl });
                    }


                }

                catch (Exception ex)
                {
                    string strRes = MessageModel.GetErrorMessage(ex);
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = backurl });
                }

                if (backurl.ToLower() == "~/home/index")

                    return RedirectToAction("index", "Home");
                else
                    return RedirectToAction("Prediction", "Game");
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        [AllowAnonymous]
        public ActionResult Prediction_UpdateBatch(string backurl, List<PredictionView> pv)
        {
            string strMessage = "",strMessageType="success";

            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST)
            {
                pv = pv.Where(p => p.selected).ToList();

                strMessage = "";
                foreach (PredictionView item in pv)
                {
                    Prediction myPrediction = new Prediction();

                    try
                    {
                        myPrediction = db.Prediction.Where(p => p.PredictId == item.PredictId).FirstOrDefault();


                        //System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
                        //System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                        //System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
                        DateTime pt1 = DateTime.Now;
                        //System.Globalization.PersianCalendar j = new System.Globalization.PersianCalendar();                    
                        //DateTime r = new DateTime();
                        //r = pv.MatchTime;
                        //r =DateTime.Parse(pt1.ToLongDateString());


                        //if ((pv.MatchTime - pt1).TotalSeconds > 300)
                        if ((item.MatchTime - pt1).TotalSeconds >= 0)
                        {

                            if (myPrediction == null)
                            {
                                myPrediction = new Prediction();

                                myPrediction.MatchId = item.MatchId.Value;
                                myPrediction.Team1Guess = item.Team1Guess;
                                myPrediction.Team2Guess = item.Team2Guess;
                                myPrediction.CompetitorId = item.CompetitorId.Value;
                                myPrediction.PredictTime = DateTime.Now;
                                myPrediction.ShowPrediction = item.ShowPrediction;
                                myPrediction.UserId = ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId;
                                myPrediction.ModifyTime = DateTime.Now;
                                myPrediction.CompetitorMatchPoint = 0;
                                db.Prediction.Add(myPrediction);
                            }
                            else
                            {
                                myPrediction.MatchId = item.MatchId.Value;
                                myPrediction.Team1Guess = item.Team1Guess;
                                myPrediction.Team2Guess = item.Team2Guess;
                                myPrediction.CompetitorId = item.CompetitorId.Value;
                                myPrediction.PredictTime = DateTime.Now;
                                myPrediction.ShowPrediction = item.ShowPrediction;
                                myPrediction.UserId = ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId;
                                myPrediction.ModifyTime = DateTime.Now;
                                myPrediction.CompetitorMatchPoint = 0;


                                db.Entry(myPrediction).State = System.Data.Entity.EntityState.Modified;
                            }

                            int n = db.SaveChanges();
                        }
                        else
                        {
                            strMessage += "\r\n" + "زمان پیش‌بینی مسایقه شماره "+item.MatchNo.ToString() +" گذشته است";
                           // return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "عدم مجوز پیش‌بینی", MessageBody = "تاریخ مجاز پیش‌بینی گذشته و یا بازی بسته شده است", BackUrl = backurl });

                        }


                    }

                    catch (Exception ex)
                    {
                        string strRes = MessageModel.GetErrorMessage(ex);
                        return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = backurl });
                    }

                   

                    

                    //if (backurl.ToLower() == "~/home/index")

                    //    return RedirectToAction("index", "Home");
                    //else
                    //    return RedirectToAction("Prediction", "Game");
                }

                //return RedirectToAction("index", "Home");

                if (strMessage == "")
                    strMessageType = "success";
                else
                    strMessageType = "error";

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = strMessageType, Title = "بروزرسانی", SubTitle = "موفق شدید", MessageBody = strMessage, BackUrl = backurl });
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "error", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        [AllowAnonymous]
        public ActionResult Prediction_delete(int predictid = 0)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.GUEST)
            {
                Prediction myPrediction = new Prediction();

                try
                {
                    myPrediction = db.Prediction.Where(t => t.PredictId == predictid).FirstOrDefault();
                    db.Prediction.Remove(myPrediction);
                    int n = db.SaveChanges();
                }

                catch (Exception ex)
                {
                    string strRes = MessageModel.GetErrorMessage(ex);
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Game/Prediction" });
                }


                return RedirectToAction("Prediction", "Game");
            }
            else
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }
        }

        /*************************************************************/
        [AllowAnonymous]
        public ActionResult PredictionTable(int allmatch=0, int pageno=1, int pagesize=10)
        {
            List<PredictionView> myPredictionList;
            int totalpages = 1;

            myPredictionList = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0}", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId }).ToList();

            if (allmatch == 0)
                myPredictionList = myPredictionList.Where(m => m.MatchState != 1).ToList();


            

            for (int i=0; i< myPredictionList.Count;i++)
            {
                System.Globalization.PersianCalendar myCalendar = new System.Globalization.PersianCalendar();

                if ( myPredictionList[i].PredictTime != null)
                {
                    DateTime dt = new DateTime();
                    if (myPredictionList[i].PredictTime != null)
                    {
                        dt = myPredictionList[i].PredictTime.Value;
                    }


                    myPredictionList[i].strJalali = myCalendar.GetYear(dt).ToString() + "/" + myCalendar.GetMonth(dt).ToString() + "/" + myCalendar.GetDayOfMonth(dt).ToString() + " " + dt.ToShortTimeString();
                }
                else
                {
                    myPredictionList[i].strJalali = "";
                }

                string s = "";
                if (myPredictionList[i].UserId != null)
                {
                    try
                    {
                        s = Convert.ToBase64String(myPredictionList[i].CompetitorThumbnailPhoto);
                    }
                    catch
                    {

                    }
                }

                myPredictionList[i].imgsrc = string.Format("data:image/jpeg;base64,{0}", s);

           
            }


            Session[GlobalModule.m_PredictionList] = myPredictionList.OrderBy(m => m.MatchNo).ToList();

            ViewBag.TotalRows = myPredictionList.Count;

            ///Paging

            /*
 select *
from [dbo].[Prediction] order by PredictId
offset @pageno*@pagesize rows 
fetch first @pagesize rows only   -- offset : نقطه شروع
 */
            if (pagesize!=0)
            {
                totalpages = (int)(Math.Ceiling((decimal)myPredictionList.Count / (decimal)pagesize));
                myPredictionList = myPredictionList.Skip(pagesize * (pageno-1)).Take(pagesize).ToList();
            }

            ViewBag.TotalPages = totalpages;
            ViewBag.PageNo = pageno;
            ViewBag.PageSize = pagesize;
            ViewBag.AllMatch = allmatch;
            ViewBag.PredictionList = myPredictionList.OrderBy(m=>m.MatchNo).ToList();            

            return View();

        }


        [AllowAnonymous]
        public ActionResult gopageajax(int allmatch = 0, int pageno = 1, int pagesize = 10, string searchkey = "")
        {
            int totalpages = 1;

            List<PredictionView> predictionlist = (List<PredictionView>)Session[GlobalModule.m_PredictionList];

            if(searchkey!="")
            {
               predictionlist = predictionlist.Where(p => p.CompetitorName.ToLower().Contains(searchkey.ToLower()) || p.Team1PName.ToLower().Contains(searchkey.ToLower()) || p.Team2PName.ToLower().Contains(searchkey.ToLower())).ToList();
                //predictionlist = predictionlist.Where(p => System.Text.RegularExpressions.Regex.IsMatch(p.CompetitorName, "*" + searchkey + "*")).ToList();

            }

            if (pagesize != 0)
            {
                totalpages = (int)(Math.Ceiling((decimal)predictionlist.Count / (decimal)pagesize));
                predictionlist = predictionlist.Skip(pagesize * (pageno - 1)).Take(pagesize).ToList();
            }


            return Json(new { allmatch, pageno, pagesize, totalpages, predictionlist }, JsonRequestBehavior.AllowGet);
        }


        [AllowAnonymous]
        public ActionResult PredictionChampion(int cupid = 0)
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.GUEST)
            {
                ViewBag.UPDATEFLAG = 0;
            }
            else
            {
                ViewBag.UPDATEFLAG = 1;
            }

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

            ViewBag.CupList = db.Cup.ToList();

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
                                           }).Where(a => a.CupId == cupid).ToList();

            ViewBag.TeamList = myCupTeam;


            List<CompetitorView> myPrediction = (from p in db.Competitor.Where(c => c.CupId == cupid)
                                                 join t1 in db.Team on p.Team1 equals t1.TeamId into g1
                                                 from mt1 in g1.DefaultIfEmpty()
                                                 join t2 in db.Team on p.Team2 equals t2.TeamId into g2
                                                 from mt2 in g2.DefaultIfEmpty()
                                                 join t3 in db.Team on p.Team3 equals t3.TeamId into g3
                                                 from mt3 in g3.DefaultIfEmpty()
                                                 join u in db.AppUser on p.CompetitorId equals u.UserId into g5
                                                 from mt5 in g5.DefaultIfEmpty()
                                                 join ct1 in db.CupTeam.Where(x => x.CupId == cupid) on p.Team1 equals ct1.TeamId into g6
                                                 from mt6 in g6.DefaultIfEmpty()
                                                 join ct2 in db.CupTeam.Where(x => x.CupId == cupid) on p.Team2 equals ct2.TeamId into g7
                                                 from mt7 in g7.DefaultIfEmpty()
                                                 join ct3 in db.CupTeam.Where(x => x.CupId == cupid) on p.Team3 equals ct3.TeamId into g8
                                                 from mt8 in g8.DefaultIfEmpty()

                                                 select new CompetitorView
                                                 {
                                                     CupId = p.CupId,
                                                     CompetitorId = p.CompetitorId,
                                                     PredictDate = p.PredictDate,
                                                     Team1 = (mt1 == null) ? 0 : p.Team1,
                                                     Team2 = (mt2 == null) ? 0 : p.Team2,
                                                     Team3 = (mt3 == null) ? 0 : p.Team3,

                                                     Team1PName = (mt1 == null) ? "" : mt1.PName,
                                                     Team2PName = (mt2 == null) ? "" : mt2.PName,
                                                     Team3PName = (mt3 == null) ? "" : mt3.PName,

                                                     CompetitorName = mt5.UserDs,

                                                     Team1Rank = (mt6 == null) ? 0 : mt6.TeamRank,
                                                     Team2Rank = (mt7 == null) ? 0 : mt7.TeamRank,
                                                     Team3Rank = (mt8 == null) ? 0 : mt8.TeamRank,

                                                     Team1con = (mt1 == null) ? "" : mt1.con,
                                                     Team2con = (mt2 == null) ? "" : mt2.con,
                                                     Team3con = (mt3 == null) ? "" : mt3.con,

                                                     InitialPoint = (p.InitialPoint == null) ? 0 : p.InitialPoint
                                                     ,
                                                     TotalPredictionsPoint = (p.TotalPredictionsPoint == null) ? 0 : p.TotalPredictionsPoint
                                                     ,
                                                     SpecialPoint = (p.SpecialPoint == null) ? 0 : p.SpecialPoint
                                                     ,
                                                     ParticipantType = p.ParticipantType
                                                     ,
                                                     RegDate = p.RegDate
                                                     ,
                                                     RegStatus = p.RegStatus
                                                     ,
                                                     ThumbnailPhoto = mt5.ThumbnailPhoto
                                                     //}).Where(m == cupid).ToList();
                                                 }).ToList();


            ViewBag.CompetitorList = Session[GlobalModule.m_CompetitorList];

            ViewBag.PredictionChampionList = myPrediction;
            ViewBag.Cup = myCup;


            return View();

        }


        [AllowAnonymous]
        public ActionResult PredictionChampion_Update(Competitor myCompetitor)
        {
            Competitor cu = new Competitor();
            int u1, c1;
            DateTime predictionduetime = new DateTime();

            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.GUEST)
            {

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/game/PredictionChampion" });
            }

            if (myCompetitor.CupId!= ((Cup)Session[GlobalModule.m_CurrentCup]).CupId)
            {

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "کاربر نامعتبر", MessageBody = "جام انتخابی جام پیش‌فرض نمی‌باشد!", BackUrl = "~/game/PredictionChampion" });
            }

            try
            {


                // u1 = ((AppUser)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserId;
                u1 = myCompetitor.CompetitorId;
                c1 = ((Cup)Session[GlobalModule.m_CurrentCup]).CupId;
                predictionduetime = ((Cup)Session[GlobalModule.m_CurrentCup]).PredictionDueTime;


                cu = db.Competitor.Where(c => c.CompetitorId == u1 && c.CupId == c1).FirstOrDefault();
            }
            catch (Exception ex)
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/Home/Index" });
            }

            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.ADMIN  && myCompetitor.CompetitorId != 0 && cu.CompetitorId != ((AppUserView)Session[GlobalModule.m_CurrentUser]).UserId)
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما نمی‌توانید پیش‌بینی دیگران را عوض کنید", BackUrl = "~/game/PredictionChampion" });
            }

            try
            {
                cu.ModifyTime = DateTime.Now;
                cu.Team1 = myCompetitor.Team1;
                cu.Team2 = myCompetitor.Team2;
                cu.Team3 = myCompetitor.Team3;

                db.Entry(cu).State = System.Data.Entity.EntityState.Modified;


                if ((predictionduetime - DateTime.Now).TotalSeconds > 0)
                {
                    int n = db.SaveChanges();
                }
                else
                {
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "عدم مجوز پیش‌بینی", MessageBody = "تاریخ مجاز پیش‌بینی گذشته است", BackUrl = "~/Game/predictionChampion" });
                }

            }

            catch (Exception ex)
            {
                string strRes = MessageModel.GetErrorMessage(ex);
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Game/PredictionChampion" });
            }


            return RedirectToAction("PredictionChampion", "Game", routeValues: new { @cupid = myCompetitor.CupId });

        }


        public ActionResult UpdateTotalPoints()
        {
            int m = 0;
            int k = 0;

            try
            {
                UpdatePredictionsPoints();
                updateTotalCompetitorPoints();

            }
            catch (Exception ex)
            {
                string strRes = MessageModel.GetErrorMessage(ex);
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Home/Index" });
            }

            return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Success", Title = "موفقیت", SubTitle = "توجه:", MessageBody = "بازشماری امتیازات انجام شد", BackUrl = "~/Home/Index" });
        }


        /// <summary>
        /// محاسبه امتیاز پیش‌بینی هر بازی برای هر کاربر
        /// </summary>
        public void UpdatePredictionsPoints()
        {
            try
            {
                int cupid = ((Cup)Session[GlobalModule.m_CurrentCup]).CupId;
                List<PredictionView> myPredictions = db.Database.SqlQuery<PredictionView>("spGetPrediction @cupid = {0}", new object[] { ((Cup)Session[GlobalModule.m_CurrentCup]).CupId }).ToList();
                List<Competitor> myCompetitors = db.Competitor.Where(c => c.CupId == cupid).ToList();
                myPredictions = myPredictions.Where(p => p.PredictId != null).ToList();
                foreach (PredictionView item in myPredictions)
                {
                    Prediction p1 = db.Prediction.Where(p => p.PredictId == item.PredictId).FirstOrDefault();
                    p1.CompetitorMatchPoint = item.GetCompetitorMatchPoint();
                    db.Entry(p1).State = System.Data.Entity.EntityState.Modified;
                }

                int n = db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        /// <summary>
        /// محاسبه مجموع امتیازهای هر کاربر
        /// </summary>
        public void updateTotalCompetitorPoints()
        {
            try
            {
                ///محاسبه امتیاز کل شرکت‌کنندگان
                int i = 0;
                foreach (CompetitorView item in (List<CompetitorView>)Session[GlobalModule.m_CompetitorList])
                {

                    //Competitor c1 = new Competitor(item);
                    

                    Competitor c1 = db.Competitor.Where(c=>c.CupId==item.CupId && c.CompetitorId==item.CompetitorId).FirstOrDefault();

                    int po1 = c1.GetTotalCompetitorMatchPoint() ;
                    int po2 =  c1.GetCompetitorPredictionChampionPoint();

                    c1.TotalPredictionsPoint = po1;
                    c1.SpecialPoint = po2;
                    db.Entry(c1).State = System.Data.Entity.EntityState.Modified;

                    //item.TotalPredictionsPoint = po1;
                    //item.SpecialPoint = po2;
                    //((List<CompetitorView>)Session[GlobalModule.m_CompetitorList])[i] = item;

                    ((List<CompetitorView>)Session[GlobalModule.m_CompetitorList])[i].TotalPredictionsPoint = po1;
                    ((List<CompetitorView>)Session[GlobalModule.m_CompetitorList])[i].SpecialPoint = po2;

                    i ++;

                }

                int n = db.SaveChanges();
                //this.TotalPoint = GetTotalCompetitorPoint() + GetCompetitorPredictionChampionPoint();
            }

            catch (Exception ex)
            {
                throw ex;
            }      

        }

   
    }
}