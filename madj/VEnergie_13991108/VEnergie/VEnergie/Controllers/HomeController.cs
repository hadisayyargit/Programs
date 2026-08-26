using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using VEnergie.DataAccess;
using VEnergie.Helpers;
using VEnergie.Models;

namespace VEnergie.Controllers
{
    public class HomeController : Controller
    {
        private DataAccess.DatabaseDataContext DB;
        private VEnergieDbContext mydbEntity=new VEnergieDbContext();
       
        public HomeController()
        {
            DB = new DataAccess.DatabaseDataContext();

            //mydbEntity.USERPROFILE.Where
            var myUserProfileRecord = new DataAccess.USERPROFILE();
            UserProfileModel objUserProfile = new VEnergie.Models.UserProfileModel();


            string unorderedList = string.Empty;
            //unorderedList = new MenuHelper().GetMenuItemData();
            ViewBag.unorderedList = unorderedList;

            myUserProfileRecord = DB.USERPROFILEs.Where(u => u.UserId == 1).FirstOrDefault();

            //   var s = mydbEntity.USERPROFILE.ToList();

            try
            {
                objUserProfile = mydbEntity.USERPROFILE.Where(u => u.UserId == 1).FirstOrDefault();
            }
            catch(Exception ex)
            {

            }

            //ViewBag.UserProfileModel = new UserProfileModel() { UserId = myUserProfileRecord.UserId, BgColor = myUserProfileRecord.BgColor, IconFile = myUserProfileRecord.IconFile, FontFamily = myUserProfileRecord.FontFamily, FontSize = myUserProfileRecord.FontSize };
            //if (ViewBag.UserProfileModel == null)
            //{
            //    ViewBag.UserProfileModel = new UserProfileModel() { BgColor = "", IconFile = "~/images/ico/favicon.ico", FontFamily = "Arial", FontSize = "11" };
            //}
        }

        //private List<Slider> getSlider()
        //{
        //    List<Slider> slider = DB.SLIDERs
        //     .Select(n =>
        //      new Slider
        //      {
        //          ID = n.ID,
        //          Name = n.Name,
        //          FileSize = n.FileSize,
        //          FilePath = n.FilePath

        //      }).ToList();
        //    return slider;
        //}

        public ActionResult Index()
        {

            //MENUITEM result = DB.MENUITEMs.Where(m => m.ID == 1).SingleOrDefault();
            //MenuItemModel MenuItemModel = new MenuItemModel
            //{
            //    ID = result.ID,
            //    MENU = result.MENU,
            //    HANDLER = result.HANDLER,
            //    PARENTID = result.PARENTID,
            //    MTEXT = result.MTEXT
            //};
            ////News();
            ////ViewBag.Slider = getSlider();
            //return View(MenuItemModel);

            return View();

        }

        //public ActionResult News()
        //{
        //    var lstNewItem = new List<NewsModel>();
        //    var result = (from n in DB.NEWs
        //                  orderby n.REGDATE descending
        //                  select new
        //                  {
        //                      n.ID,
        //                      n.TITLE,
        //                      n.NEWSTEXT,
        //                      n.REGDATE,
        //                      n.VISIT,
        //                  }).ToList();

        //    foreach (var n in result)
        //    {
        //        var newsModel = new NewsModel()
        //        {
        //            ID = n.ID,
        //            TITLE = n.TITLE,
        //            NEWSTEXT = n.NEWSTEXT,
        //            REGDATE = n.REGDATE,
        //            VISIT = n.VISIT
        //        };

        //        lstNewItem.Add(newsModel);
        //    }

        //    ViewBag.News = lstNewItem.Take(5);
        //    ViewBag.AllNews = lstNewItem;

        //    return View(lstNewItem);
        //}
        //private MenuItemModel getTechByID(int? id)
        //{
        //    MenuItemModel techbyId = (from n in DB.MENUITEMs
        //                              select new MenuItemModel
        //                              {
        //                                  ID = n.ID,
        //                                  MENU = n.MENU,
        //                                  MTEXT = n.MTEXT
        //                              }).Where(n => n.ID == id).FirstOrDefault();

        //    List<FileDetailsModel> fileDetails = (from n in DB.FILEDETAILs
        //                                          select new FileDetailsModel
        //                                          {
        //                                              ID = n.ID,
        //                                              FILENAME = n.FILENAME,
        //                                              MENUITEMID = n.MENUITEMID
        //                                          }).Where(n => n.MENUITEMID.Equals(id)).ToList();
        //    if (fileDetails != null)
        //        ViewBag.fileDetails = fileDetails;


        //    return techbyId;
        //}

        //public ActionResult TechById(int? id)
        //{
        //    if (id != null)
        //    {
        //        if (Convert.ToBoolean(Session["ISADMIN"]))
        //        {
        //            return View(getTechByID(id));
        //        }
        //        else
        //        {
        //            int uID = Convert.ToInt32(Session["userID"]);
        //            var result = (from n in DB.UMs
        //                          where n.MENUITEMID == id && n.USERID == uID
        //                          select n).SingleOrDefault();
        //            if (result != null)
        //            {
        //                return View(getTechByID(id));
        //            }
        //            else
        //            {
        //                ViewBag.Result = "You do not have permission to access this page." + "</br>"
        //                    + " Please contact the site admin";

        //            }
        //        }
        //    }
        //    return View();
        //}

        //public ActionResult NewsById(int? id)
        //{
        //    if (id != null)
        //    {
        //        var result = (from n in DB.NEWs
        //                      select new
        //                      {
        //                          n.ID,
        //                          n.TITLE,
        //                          n.NEWSTEXT,
        //                          n.REGDATE,
        //                          n.VISIT
        //                      }).Where(n => n.ID == id).FirstOrDefault();
        //        if (result != null)
        //        {
        //            var newsModel = new NewsModel()
        //            {
        //                ID = result.ID,
        //                TITLE = result.TITLE,
        //                NEWSTEXT = result.NEWSTEXT,
        //                REGDATE = result.REGDATE,
        //                VISIT = result.VISIT
        //            };
        //            return View(newsModel);
        //        }
        //    }
        //    return View();
        //}
        //public ActionResult Product(int? id)
        //{
        //    var lstMenuItem = new List<MenuItemModel>();
        //    if (id != null)
        //    {
        //        var result = (from n in DB.MENUITEMs
        //                      select new
        //                      {
        //                          n.ID,
        //                          n.MENU,
        //                          n.HANDLER,
        //                          n.PARENTID,
        //                          n.MTEXT,
        //                      }).ToList();
        //        if (result != null)
        //        {
        //            foreach (var n in result)
        //            {
        //                var MenuModel = new MenuItemModel()
        //                {
        //                    ID = n.ID,
        //                    HANDLER = n.HANDLER,
        //                    MENU = n.MENU,
        //                    MTEXT = n.MTEXT,
        //                    PARENTID = n.PARENTID
        //                };
        //                lstMenuItem.Add(MenuModel);
        //            }
        //            ViewBag.ProductDataFilter = lstMenuItem.Where(n => n.PARENTID == id);
        //            return View(lstMenuItem.Where(n => n.ID == id).FirstOrDefault());
        //        }
        //    }
        //    return View();
        //}

        //private void getcontact()
        //{
        //    var contactText = DB.MENUITEMs.Where(m => m.ID == 3).SingleOrDefault();

        //    MenuItemModel menu = new MenuItemModel()
        //    {
        //        ID = contactText.ID,
        //        MTEXT = contactText.MTEXT
        //    };
        //    ViewBag.GetContact = menu;
        //}

        //public ActionResult Contact()
        //{
        //    getcontact();

        //    return View();
        //}

        //[HttpPost]
        //public async Task<ActionResult> Contact(SendMailModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
        //            var message = new MailMessage();
        //            message.To.Add(new MailAddress("info@vistaenergie.com"));
        //            message.From = new MailAddress("info@vistaenergie.com");
        //            message.Subject = model.EmailSubject;
        //            message.Body = string.Format(body,
        //                                         model.FromEmail,
        //                                         model.FromEmail,
        //                                         model.EMailBody);
        //            message.IsBodyHtml = true;
        //            using (var smtp = new SmtpClient())
        //            {
        //                var credential = new NetworkCredential
        //                {
        //                    UserName = "info@vistaenergie.com",
        //                    Password = "Safdari@2222"
        //                };
        //                smtp.Credentials = credential;
        //                smtp.Host = "mail.vistaenergie.com";
        //                smtp.Port = 25;
        //                smtp.EnableSsl = false;
        //                await smtp.SendMailAsync(message);
        //            }
        //            @ViewBag.Status = "Message sent successfully";
        //            ModelState.Clear();
        //            getcontact();
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //    }
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Error()
        //{
        //    return View();
        //}

        //public ActionResult TechnicalInf()
        //{
        //    var techmText = DB.MENUITEMs.Where(m => m.ID == 4).SingleOrDefault();
        //    var result = DB.MENUITEMs.Where(m => m.PARENTID == 4).ToList();
        //    List<MenuItemModel> lstMenuItem = new List<MenuItemModel>();
        //    foreach (var mnu in result)
        //    {
        //        var mnuModel = new MenuItemModel();
        //        mnuModel.ID = mnu.ID;
        //        mnuModel.MENU = mnu.MENU;
        //        mnuModel.HANDLER = mnu.HANDLER;
        //        mnuModel.PARENTID = mnu.PARENTID;
        //        mnuModel.MTEXT = mnu.MTEXT;
        //        lstMenuItem.Add(mnuModel);
        //    }
        //    ViewBag.mText = techmText.MTEXT;
        //    return View(lstMenuItem);
        //}

        //[HttpGet]
        //public FileResult DownLoadFile(int id)
        //{
        //    var result = DB.FILEDETAILs.ToList();
        //    List<FileDetailsModel> DetList = new List<FileDetailsModel>();
        //    foreach (var mnu in result)
        //    {
        //        var mnuModel = new FileDetailsModel();
        //        mnuModel.ID = mnu.ID;
        //        mnuModel.FILENAME = mnu.FILENAME;
        //        mnuModel.FILECONTENT = mnu.FILECONTENT.ToArray();
        //        DetList.Add(mnuModel);
        //    }

        //    //DetList = sqlMa
        //    //List<FileDetailsModel> ObjFiles = GetFileList();

        //    var FileById = (from FC in DetList
        //                    where FC.ID.Equals(id)
        //                    select new { FC.FILENAME, FC.FILECONTENT }).ToList().FirstOrDefault();

        //    return File(FileById.FILECONTENT, "application/pdf", FileById.FILENAME);

        //}

        //[HttpGet]
        //public ActionResult GetFile(int id)
        //{

        //    return View();
        //}
    }
}