using Shayatech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shayatech.Helper
{
    public class GeneralModule
    {
        

        public static string[] m_JalaliWeekDayNames = new string[] { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه" };
        public static string[] m_JalaliMonthNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

        public static string[] AlphaNumeric1 = { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه", "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هیجده", "نوزده" };
        public static string[] AlphaNumeric2 = { "", "ده", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        public static string[] AlphaNumeric3 = { "", "یکصد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };

        public const string m_CurrentUser = "currentuser";
        public const string m_BlogList = "bloglist";
        public const string m_NewsList = "newslist";
        public const string m_HotNewsItem = "hotnewsitem";
        

        public const string m_JalaliToday = "jalalitoday";
        public const string m_JalaliTodayName = "jalalitodayname";



        public static void SetTopBlogs()
        {
            ShayaDbContext db = new ShayaDbContext();

            int pagesize = 3, pageindex = 1;

            List<Blog> myBlogs = db.Blog.ToList();

            var shayaBlogList = myBlogs.Where(m => m.IsNews == false & m.IsActive==true)
            .OrderByDescending(x => x.PublishDate)
            .Skip(pagesize * (pageindex - 1)).Take(pagesize)
            .ToList();

            var shayaNewsList = myBlogs.Where(m => m.IsNews == true & m.IsActive == true)
                .OrderByDescending(x => x.PublishDate)
                .Skip(pagesize * (pageindex - 1)).Take(pagesize)
                .ToList();


            var myHotNews = new Blog();

            try
            {
                myHotNews = db.Blog.Where(m => m.IsHotNews == true & m.IsActive == true).Last();
            }
            catch (Exception ex)
            {

            }

            HttpContext.Current.Session[m_NewsList] = shayaNewsList;
            HttpContext.Current.Session[m_BlogList] = shayaBlogList;
            HttpContext.Current.Session[m_HotNewsItem] = myHotNews;
        }


    }



}