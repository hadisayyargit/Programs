using pharmacy.Helper;
using pharmacy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace pharmacy
{
    public class MvcApplication : System.Web.HttpApplication
    {
        pharmacyDbContext db = new pharmacyDbContext();

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
            Session[GeneralModule.m_JalaliToday] = myCalendar.GetYear(myDate) + "/" + myCalendar.GetMonth(myDate).ToString("00") + "/" + myCalendar.GetDayOfMonth(myDate).ToString("00");
            Session[GeneralModule.m_JalaliTodayName] = Helper.GeneralModule.m_JalaliWeekDayNames[(((int)myCalendar.GetDayOfWeek(myDate)) + 1) % 7] + " " + myCalendar.GetDayOfMonth(myDate) + " " + Helper.GeneralModule.m_JalaliMonthNames[myCalendar.GetMonth(myDate) - 1] + " " + myCalendar.GetYear(myDate);

            Session[GeneralModule.m_CurrentUser] = new AppUser { LoginName = "guest",  UserDs = "کاربر مهمان", UserId = 0};

    
        }
    }
}
