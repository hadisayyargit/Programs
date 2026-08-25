using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bongah.ir.Models;


namespace bongah.ir.Controllers
{
    public class HomeController : Controller
    {
        AdventureWorks2012Entities AdventureWorksDB = new AdventureWorks2012Entities();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            /*

            /// روش دوم بارگذاری عکس باینری بدون استفاده از فایل تصویر
            
            
            //بدست آوردن مقدار باینری یک تصویر
            //string path = Server.MapPath("~/Images/gallery/more.jpg");
            //byte[] imageByteData = System.IO.File.ReadAllBytes(path);
             
            ProductPhoto myPhoto = AdventureWorksDB.ProductPhoto.Where(m => m.ProductPhotoID == 80).First();
            byte[] imageByteData = myPhoto.LargePhoto;
            string imageBase64Data = Convert.ToBase64String(imageByteData);
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            ViewBag.ImageData = imageDataURL;


            //<img src="@ViewBag.ImageData" />


            ///روش مستقیم
            //< img src="data:image/jpg;base64,@(Convert.ToBase64String(item.PhotoImage))" alt="@item.orientation" />         

             */

            ///ذخیره تصویر
            //SaveImage();

            return View();
        }

        /// <summary>
        /// روش دوم بارگذاری عکس باینری بدون استفاده از فایل تصویر
        /// </summary>
        /// <returns></returns>
        public ActionResult GetImage()
        {
            string path = Server.MapPath("~/Images/gallery/more.jpg");
            byte[] imageByteData = System.IO.File.ReadAllBytes(path);
            
            return File(imageByteData, "image/jpg");

            // <img src='@Url.Action("GetImage", "Home")'/>
        }


        public void SaveImage()
        {
            string path = Server.MapPath("~/Images/gallery/tmp1.jpg");
            ProductPhoto myPhoto = AdventureWorksDB.ProductPhoto.Where(m => m.ProductPhotoID == 80).First();
            byte[] imageByteData = myPhoto.LargePhoto;

            System.IO.File.WriteAllBytes(path, imageByteData);

        }


    }
}
