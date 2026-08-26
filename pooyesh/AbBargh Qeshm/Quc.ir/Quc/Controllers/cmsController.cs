using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using quc.Models;
using System.IO;
using System.Drawing;

namespace quc.Controllers
{
    public class cmsController : Controller
    {
        private qucdbContext db = new qucdbContext();


        // GET: Blogs

        public ActionResult BlogList(int pageindex = 1, int pagesize = 6)
        {
            List<Blog> myBlogs = db.Blog.ToList();

            if (pageindex < 1) pageindex = 1;

            var myBlogs2 = myBlogs
            //    .Select(x => new 
            //{
            //    //RowIndex = index++
            //    //,
            //    blogid = x.BlogId
            //    ,
            //    title = x.Title
            //    ,
            //    body = x.Body
            //    ,
            //    imagename = x.ImageName
            //    ,
            //    isactive = x.IsActive
            //    ,
            //    publishdate = x.PublishDate
            //    ,
            //    authorid = x.AuthorId

            //})
            .OrderByDescending(x => x.PublishDate)
            .Skip(pagesize * (pageindex - 1)).Take(pagesize)
            .ToList();

            ViewBag.BlogList = myBlogs2;
            ViewBag.pageindex = pageindex;
            ViewBag.lastpage = (int)(Math.Ceiling((double)myBlogs.Count / (double)pagesize));

            return View();
        }

        //for ajax using
        //public ActionResult GetSellers(string branch)
        //{

        //    var result = db.vwSeller.Where(a => a.BRANCH == branch).ToList();

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult BlogPost(int blogid = 0)
        {
            Blog myModel = db.Blog.Where(m => m.BlogId == blogid).FirstOrDefault();
            if (myModel == null)
            {
                myModel = new Blog();
                myModel.BlogId = 0;
                myModel.PublishDate = DateTime.Now;
            }
            return View(myModel);
        }

        public ActionResult GalleryList()
        {
            var myList = Directory.GetFiles(Server.MapPath("~/images/gallery/"));

            ViewBag.GalleryList = myList.ToList();
            return View();
        }

        public ActionResult GallerySingle(string imagename = "")
        {
            if (imagename == "" || imagename == "0")
            {

            }

            ViewBag.ImageName = imagename;
            return View();
        }

        public ActionResult deleteBlog(int blogid = 0)
        {
            try
            {
                Blog myblog = db.Blog.Where(m => m.BlogId == blogid).First();
                if (myblog.BlogId != 0)
                {
                    //db.Entry(myModel).State = EntityState.Deleted;
                    db.Blog.Remove(myblog);
                    db.SaveChanges();

                    string strFilename = Path.Combine(Server.MapPath("~/images/blog/"), myblog.ImageName);

                    try
                    {
                        System.IO.File.Delete(strFilename);
                    }
                    catch (Exception ex)
                    {

                    }

                }


            }
            catch
            {

            }

            return RedirectToAction("BlogList");
        }

        public ActionResult deleteGallery(string imagename = "")
        {
            string strFilename = Path.Combine(Server.MapPath("~/images/gallery/"), imagename);

            try
            {
                System.IO.File.Delete(strFilename);
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("GalleryList");
        }

        public string GetImage(string imagename)
        {
            string strPhysicalFilename = "", strServerFileName = "";



            try
            {
                strPhysicalFilename = Path.Combine(Server.MapPath("~/temp"), "p_" + imagename)
                + ".jpg";

                strServerFileName = "~/temp/" + "p_" + imagename + ".jpg";

                //MemoryStream ms = new MemoryStream(myPerson.Photo);
                MemoryStream ms = new MemoryStream();
                Image img1 = Image.FromStream(ms);
                img1.Save(strPhysicalFilename, System.Drawing.Imaging.ImageFormat.Jpeg);

                //db.Database.ExecuteSqlCommand("update person set  address={0} where PersonId={1}", "image saved", 1);
            }

            catch (Exception ex)
            {
                strServerFileName = "";
            }


            return strServerFileName;
        }

        public void UploadImage(HttpPostedFileBase UserImageUrlUpload, bool ingallery=true)
        {
            string strFilename = "";

            if (UserImageUrlUpload != null && UserImageUrlUpload.ContentLength > 0)
            {
                try
                {
                    if (ingallery)
                        strFilename = Path.Combine(Server.MapPath("~/images/gallery/"), UserImageUrlUpload.FileName);
                    else
                        strFilename = Path.Combine(Server.MapPath("~/images/blog/"), UserImageUrlUpload.FileName);

                    UserImageUrlUpload.SaveAs(strFilename);

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
            }
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult UpdateGallery(HttpPostedFileBase UserImageUrlUpload)
        {
            string strRes = "";

            try
            {
                UploadImage(UserImageUrlUpload,true);
                /// update at database
                //ViewBag.Message = UpdateImage(strFilename,0);

                ///Get Last Picture
                //GetImage();

            }
            catch (Exception ex)
            {
                strRes = "ERROR:" + ex.Message.ToString();
            }

            return RedirectToAction("GalleryList");

        }

        public string UpdateImage(string strFilename, int userid = 0)
        {
            string strRes = "";

            byte[] bb = new byte[8000];
            MemoryStream s1 = new MemoryStream();

            Image img1 = Image.FromFile(strFilename);
            //img1.Save(s1, System.Drawing.Imaging.ImageFormat.Jpeg);
            img1.GetThumbnailImage(160, 200, null, new System.IntPtr()).Save(s1, System.Drawing.Imaging.ImageFormat.Jpeg);

            img1.Dispose();

            bb = s1.ToArray();

            try
            {
                //Person p = db.Person.Find(userid);
                //p.Photo = bb;
                //db.Entry(p).State = EntityState.Modified;
                //db.SaveChanges();
            }

            catch (Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult UpdateBlog(HttpPostedFileBase UserImageUrlUpload, Blog myModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (UserImageUrlUpload != null)
                    {
                        myModel.ImageName = UserImageUrlUpload.FileName;
                        try
                        {
                            UploadImage(UserImageUrlUpload,false);
                        }
                        catch (Exception ex)
                        {
                            //= "ERROR:" + ex.Message.ToString();
                        }
                    }
                    else
                    {
                        myModel.ImageName = null;
                    }

                    if (myModel.BlogId == 0)
                    {
                        db.Blog.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }

                    int m = db.SaveChanges();

                }
                catch (Exception ex)
                {

                }
            }

            return RedirectToAction("BlogList");

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
