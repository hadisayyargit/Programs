using System.IO;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using quc.Models;

namespace quc
{
    public class HomeController : Controller
    {
        private qucdbContext db = new qucdbContext();
        public ActionResult Index()
        {
            int pagesize = 3, pageindex = 1;
            
            var myList = Directory.GetFiles(Server.MapPath("~/images/gallery/"));
            ViewBag.GalleryList = myList.ToList();

            List<Blog> myBlogs = db.Blog.ToList();

            var qucBlogList = myBlogs.Where(m=>m.IsQeshmNews==false)
            .OrderByDescending(x => x.PublishDate)
            .Skip(pagesize * (pageindex - 1)).Take(pagesize)
            .ToList();

            var qeshmBlogList = myBlogs.Where(m => m.IsQeshmNews == true)
            .OrderByDescending(x => x.PublishDate)
            .Skip(pagesize * (pageindex - 1)).Take(pagesize)
            .ToList();

            var myHotNews = new Blog();

            try
            {
                 myHotNews = myBlogs.Where(m => m.IsHotNews == true).Last();
            }
            catch
            {
                
            }

            ViewBag.qucBlogList = qucBlogList;
            ViewBag.qeshmBlogList = qeshmBlogList;
            ViewBag.HotNews = myHotNews;

            return View();
        }

        public ActionResult About()
        {
                        
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Organization()
        {
            return View();
        }

        public ActionResult policy()
        {
            return View();
        }

        public ActionResult portfolio()
        {
            return View();
        }
    }
}