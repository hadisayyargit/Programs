using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CommonUnit;
using footballcup.Models;

namespace footballcup
{
    
    public class MvcApplication : System.Web.HttpApplication
    {
        footballcupDbContext db = new footballcupDbContext();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            DateTime myDate;
            //myDate= new DateTime(2015, 8, 3);
            myDate = DateTime.Today;
            System.Globalization.PersianCalendar myCalendar = new System.Globalization.PersianCalendar();
            Session[GlobalModule.m_JalaliToday] = myCalendar.GetYear(myDate) + "/" + myCalendar.GetMonth(myDate).ToString("00") + "/" + myCalendar.GetDayOfMonth(myDate).ToString("00");
            Session[GlobalModule.m_JalaliTodayName] = GlobalModule.m_JalaliWeekDayNames[(((int)myCalendar.GetDayOfWeek(myDate)) + 1) % 7] + " " + myCalendar.GetDayOfMonth(myDate) + " " + GlobalModule.m_JalaliMonthNames[myCalendar.GetMonth(myDate) - 1] + " " + myCalendar.GetYear(myDate);
            Session[GlobalModule.m_CurrentUser] = new AppUserView { LoginName = "guest", UserRole = (int)UserRoleEnum.GUEST };
            Session[GlobalModule.m_NotificationCount] = 0;
            try
            {
                Session[GlobalModule.m_CurrentCup] = db.Cup.Where(c => c.IsDefaultCup == true).FirstOrDefault();
                if (Session[GlobalModule.m_CurrentCup] == null)
                    Session[GlobalModule.m_CurrentCup] = new Cup();

                int m = ((Cup)Session[GlobalModule.m_CurrentCup]).CupId;

                int n;


                List<CompetitorView> CompetitorViewlist = (from c in db.Competitor.Where(cu => cu.CupId == m)
                                                           join u in db.AppUser on c.CompetitorId equals u.UserId into t1
                                                           from t11 in t1.DefaultIfEmpty()
                                                           select new CompetitorView
                                                           {
                                                               CompetitorId = c.CompetitorId,
                                                               CompetitorName = t11.UserDs,
                                                               ThumbnailPhoto = t11.ThumbnailPhoto,
                                                               CupId = m,
                                                               Team1 = (c.Team1 == null) ? 0 : c.Team1,
                                                               Team2 = (c.Team2 == null) ? 0 : c.Team2,
                                                               Team3 = (c.Team3 == null) ? 0 : c.Team3,
                                                               InitialPoint = c.InitialPoint,
                                                               SpecialPoint = c.SpecialPoint,
                                                               TotalPredictionsPoint = c.TotalPredictionsPoint,
                                                               ParticipantType = c.ParticipantType,
                                                               RegDate = c.RegDate,
                                                               RegStatus = c.RegStatus,
                                                               ModifyTime = c.ModifyTime,
                                                               PredictDate = c.PredictDate

                                                           }).ToList();



                Session[GlobalModule.m_CompetitorList] = CompetitorViewlist;

            }
            catch (Exception ex)
            {

            }



            Session[GlobalModule.m_Message] = "";
        

        }
    }
}
