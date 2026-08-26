using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Shayatech.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /// for adding tables to localdb
            //db.AppUser.Add(new Models.AppUser { UserName = "admin", Password = "", UserId = 0 });
            //db.SaveChanges();

            ViewBag.Message = "طراحی ، توسعه و بهبود سیستم های نرم افزاری برای تحول سازمان  ،کسب کار های نوین و تصمیم گیری";
            var myList = Directory.GetFiles(Server.MapPath("~/images/gallery/"));
            ViewBag.GalleryList = myList.ToList();

            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult CRM()
        {
            return View();
        }

        public ActionResult ECommerce()
        {
            return View();
        }

        public ActionResult BI()
        {
            return View();
        }

        public ActionResult FIPI()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();        
        }

        public ActionResult DocEM()
        {
            ViewBag.Message = "Your contact page.";

            return View();        
        }

        public ActionResult Overlook()
        {
            ViewBag.Message = "Your contact page.";

            return View();        
        }    

        
    }
}
