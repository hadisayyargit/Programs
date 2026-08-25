using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using pharmacy.Models;
using System.IO;
using System.Drawing;

namespace pharmacy.Controllers
{
    public class cmsController : Controller
    {
        private pharmacyDbContext db = new pharmacyDbContext();

        // GET: Blogs

        public ActionResult BlogList(int pageindex = 1, int pagesize = 6,bool isNews=false, bool showdiactive=false)
        {           
            //List<Blog> myBlogs = db.Blogs.Where(b => b.BlogId >= 1).ToList();
            List<Cms> myBlogs = db.Cms.ToList();

            if (pageindex < 1) pageindex = 1;

            if (showdiactive)
            {
                ViewBag.Title = "فهرست پستهای تایید نشده/غیرفعال";
                ViewBag.IsNews = false;

                var myList = myBlogs
                    .Where(m=> m.IsActive == false)
                .OrderByDescending(x => x.PublishDate)
                .Skip(pagesize * (pageindex - 1)).Take(pagesize)
                .ToList();

                ViewBag.BlogList = myList;
                ViewBag.pageindex = pageindex;
                ViewBag.lastpage = (int)(Math.Ceiling((double)myList.Count / (double)pagesize));
            }
            else
            {

                if (isNews)
                {
                    ViewBag.Title = "فهرست اخبار";
                    ViewBag.IsNews = true;

                    var myNews = myBlogs
                        .Where(m => m.IsChat == false & m.IsActive == true)
                    .OrderByDescending(x => x.PublishDate)
                    .Skip(pagesize * (pageindex - 1)).Take(pagesize)
                    .ToList();

                    ViewBag.BlogList = myNews;
                    ViewBag.pageindex = pageindex;
                    ViewBag.lastpage = (int)(Math.Ceiling((double)myNews.Count / (double)pagesize));
                }

                else
                {
                    ViewBag.Title = "فهرست بلاگها";
                    ViewBag.IsNews = false;

                    var myBlogs2 = myBlogs
                        .Where(m => m.IsChat == true & m.IsActive == true)
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
                    ViewBag.lastpage = (int)(Math.Ceiling((double)myBlogs2.Count / (double)pagesize));
                }
            }

            return View();
        }

        //for ajax using
        //public ActionResult GetSellers(string branch)
        //{

        //    var result = db.vwSeller.Where(a => a.BRANCH == branch).ToList();

        //    return Json(result, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult BlogPost(int blogid=0,bool isNews=false)
        {
            Cms myModel = db.Cms.Where(m=>m.CmsId == blogid).FirstOrDefault();
            if(myModel==null)
            {
                myModel = new Cms();
                myModel.CmsId = 0;
                myModel.PublishDate = DateTime.Now;
                myModel.IsChat = !isNews;
            }

            if(isNews)
            {
                ViewBag.Title = "جزئیات خبر";
            }
            else
            {
                ViewBag.Title = "جزئیات بلاگ";
            }

            return View(myModel);
        }

        public ActionResult GalleryList()
        {
            var myList = Directory.GetFiles(Server.MapPath("~/assets/images/gallery/"));
            
            ViewBag.GalleryList = myList.ToList();
            return View();
        }

        public ActionResult GalleryPost(string imagename="")
        {
            if(imagename=="" || imagename=="0")
            {

            }

            ViewBag.ImageName = imagename;
            return View();
        }

        public ActionResult deleteBlog(int blogid = 0)
        {
            Cms myblog = db.Cms.Where(m => m.CmsId == blogid).First();

            try
            {
                
                if (myblog.CmsId != 0)
                {
                    //db.Entry(myModel).State = EntityState.Deleted;
                    db.Cms.Remove(myblog);
                    db.SaveChanges();

                    string strFilename = Path.Combine(Server.MapPath("~/assets/images/blog/"), myblog.ImageName);

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


            return RedirectToAction("BlogList", routeValues: new { isNews = myblog.IsChat });
            
        }

        public ActionResult deleteGallery(string imagename = "")
        {
            string strFilename = Path.Combine(Server.MapPath("~/assets/images/gallery/"), imagename);

            try
            {
                System.IO.File.Delete(strFilename);
            }
            catch(Exception ex)
            {

            }

            return RedirectToAction("GalleryList");
        }

        public string GetImage(string imagename )
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

        public void UploadImage(HttpPostedFileBase UserImageUrlUpload, bool ingallery = true)
        {
            string strFilename = "";

            if (UserImageUrlUpload != null && UserImageUrlUpload.ContentLength > 0)
            {
                try
                {
                    if (ingallery)
                    {
                        strFilename = Path.Combine(Server.MapPath("~/assets/images/gallery/"), UserImageUrlUpload.FileName);
                        //Response.Redirect("http://www."+ UserImageUrlUpload.FileName + ".com");
                    }
                    else
                        strFilename = Path.Combine(Server.MapPath("~/assets/images/blog/"), UserImageUrlUpload.FileName);

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
        public ActionResult UpdateBlog(HttpPostedFileBase UserImageUrlUpload,Cms myModel)
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
                            UploadImage(UserImageUrlUpload, false);
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

                    if (myModel.CmsId == 0)
                    {
                        db.Cms.Add(myModel);
                    }
                    else
                    {
                        db.Entry(myModel).State = EntityState.Modified;
                    }

                    myModel.AuthorId = ((AppUser)Session[Helper.GeneralModule.m_CurrentUser]).UserId;

                    int m = db.SaveChanges();

                }
                catch (Exception ex)
                {

                }
            }

            return RedirectToAction("BlogList",routeValues:new { isNews = !myModel.IsChat });

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
