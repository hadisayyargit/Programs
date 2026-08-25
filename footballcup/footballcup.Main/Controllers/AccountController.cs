using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using footballcup.Models;
using CommonUnit;
using System.IO;
using System.Drawing;
using System.Data;
using System.Collections.Generic;

namespace footballcup.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        footballcupDbContext db = new footballcupDbContext();


        [AllowAnonymous]
        public ActionResult UserProfile()
        {

            ViewBag.UserList = db.AppUser.ToList();

            return View(Session[CommonUnit.GlobalModule.m_CurrentUser]);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult UserProfile_Update(HttpPostedFileBase UserImageUrlUpload, AppUserView myUser)
        {
            string strFilename = "";
            byte[] myImageBinary = null;

            if ( (myUser.UserRole == (int)UserRoleEnum.ADMIN ) && ((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole != (int)UserRoleEnum.ADMIN)
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما اجازه تغییر نقش به راهبر را ندارید", BackUrl = "~/Account/UserProfile" });
            }
       

            try
            {
                var result = db.AppUser.Where(u => u.UserId == myUser.UserId).FirstOrDefault();

                result.LoginName = myUser.LoginName;
                result.UserDs = myUser.UserDs;
                result.Email = myUser.Email;
                result.Phone = myUser.Phone;
                result.UserRole = myUser.UserRole;
                result.Enabled = myUser.Enabled;

                if (myUser.ConfirmPassword != null && myUser.ConfirmPassword == myUser.Password)
                    result.Password = myUser.Password;

                if (UserImageUrlUpload != null)
                {
                    try
                    {

                        strFilename = Path.Combine(Server.MapPath("~/temp/"), UserImageUrlUpload.FileName);
                        Helper.UploadFile(UserImageUrlUpload, strFilename);
                        myImageBinary = Helper.GetImage(strFilename, System.Drawing.Imaging.ImageFormat.Jpeg, 160, 200);
                        result.ThumbnailPhoto = myImageBinary;
                    }
                    catch
                    {
                    }
                }

                db.Entry(result).State = System.Data.Entity.EntityState.Modified;
                int n = db.SaveChanges();

                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Success", Title = "موفقیت", SubTitle = "توجه:", MessageBody = "مشخصات کاربر اصلاح شد", BackUrl = "~/Account/UserProfile" });
            }
            catch (Exception ex)
            {
                string strRes = MessageModel.GetErrorMessage(ex);
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/Account/UserProfile" });
            }


        }

        [AllowAnonymous]
        public ActionResult SelectUser(int userid)
        {
            AppUser user1 = new AppUser();
            AppUserView result=null;

            try
            {
                user1 = db.AppUser.Where(u => u.UserId == userid).FirstOrDefault();
                result = new AppUserView(user1);

                if (result.UserRole== (int)UserRoleEnum.GUEST)
                    result.ThumbnailPhotoFileName = "assets/images/person/avatar3.png";
                else
                {
                    if (result.UserRole == (int)UserRoleEnum.ADMIN)
                        result.ThumbnailPhotoFileName = "assets/images/person/avatar1.png";

                    else
                    {
                        if (result.ThumbnailPhoto == null)
                            result.ThumbnailPhotoFileName = "assets/images/person/avatar2.png";
                        else
                            result.ThumbnailPhotoFileName = null;
                    }
                }
            }
            catch
            {

            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        [AllowAnonymous]
        public ActionResult SignIn()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Authenticate(string loginname = "", string password = "")
        {
            var result = db.AppUser.Where(u => (u.LoginName == loginname | u.Phone == loginname | u.Email == loginname) & u.Password == password).FirstOrDefault();

            if (result != null)
            {
                if (result.LoginName == null) result.LoginName = "";

                Session[GlobalModule.m_CurrentUser] = new AppUserView(result);

                if (result.UserRole == (int)UserRoleEnum.GUEST)
                    ((AppUserView)Session[GlobalModule.m_CurrentUser]).ThumbnailPhotoFileName = "assets/images/person/avatar3.png";
                else
                {
                    if (result.UserRole == (int)UserRoleEnum.ADMIN)
                    {
                        if (result.ThumbnailPhoto == null)
                            ((AppUserView)Session[GlobalModule.m_CurrentUser]).ThumbnailPhotoFileName = "assets/images/person/avatar1.png";
                        else
                            ((AppUserView)Session[GlobalModule.m_CurrentUser]).ThumbnailPhotoFileName = null;
                    }
                    else
                    {
                        if (result.ThumbnailPhoto == null)
                            ((AppUserView)Session[GlobalModule.m_CurrentUser]).ThumbnailPhotoFileName = "assets/images/person/avatar2.png";
                        else
                            ((AppUserView)Session[GlobalModule.m_CurrentUser]).ThumbnailPhotoFileName = null;
                    }


                    ///گرفتن 4 رکورد آخر
                    //List<footballcup.Models.CmsView> myChatList = new List<footballcup.Models.CmsView>();
                    //try
                    //{
                    //    List<Cms> myList = db.Cms.Where(m => m.IsMessage == true && m.IsActive == true && m.ReadStatus==0 && (m.TargetReceiver == 0 || m.TargetReceiver ==result.UserId)).OrderByDescending(m => m.CmsId).ToList();
                    //    Session[GlobalModule.m_NotificationCount] = myList.Count;
                    //    myList = myList.Take(4).ToList();
                    //    Session[GlobalModule.m_NotificationList] = myList.Join(db.AppUser, c => c.AuthorId, a => a.UserId, (c, a) => new CmsView { CmsId = c.CmsId, Title = c.Title, Body = c.Body, AuthorId = c.AuthorId, IsActive = c.IsActive, IsChat = c.IsChat, IsSlider = c.IsSlider,IsMessage=c.IsMessage,TargetReceiver=c.TargetReceiver, ReadStatus = c.ReadStatus, ParentCmsId = c.ParentCmsId, IsHotNews = c.IsHotNews, PublishDate = c.PublishDate, PictureFile = c.PictureFile, AuthorDs = a.UserDs, AuthorThumbnail = a.ThumbnailPhoto }).ToList();

                    //}
                    //catch
                    //{
                    //}

                }


            }

            return RedirectToAction("index", "home");
        }
        [AllowAnonymous]
        public ActionResult SignUp()
        {
            return View();
        }


        [AllowAnonymous]
        public ActionResult user_delete(int userid)
        {

            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.ADMIN )
            {
                Competitor mycompetitor = new Competitor();
                List<Prediction> mypredictionlist = new List<Prediction>();
                AppUser myuser = new AppUser();

        

                try
                {
                    mypredictionlist = db.Prediction.Where(t => t.CompetitorId == userid).ToList();
                    db.Prediction.RemoveRange(mypredictionlist);
                    int n2 = db.SaveChanges();
                }
                catch
                {

                }

                try
                {
                    mycompetitor = db.Competitor.Where(t => t.CompetitorId == userid).FirstOrDefault();
                    db.Competitor.Remove(mycompetitor);
                    int n3 = db.SaveChanges();
                }
                catch
                {

                }

                try
                {
                    myuser = db.AppUser.Where(t => t.UserId == userid).FirstOrDefault();
                    db.AppUser.Remove(myuser);
                    int n4 = db.SaveChanges();
                }

                catch (Exception ex)
                {
                    string strRes = MessageModel.GetErrorMessage(ex);
                    return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "", MessageBody = strRes, BackUrl = "~/account/userprofile" });
                }


                return RedirectToAction("UserProfile", "Account");
            }
            else
            {

                return RedirectToAction("UserProfile", "Account");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult SignUp(HttpPostedFileBase UserImageUrlUpload, AppUserView myModel)
        {
            string strRes = "";
            string strFilename = "";
            byte[] myImageBinary = null;

            //if(ModelState.IsValid)
            //{
            //}

            try
            {
                strFilename = Path.Combine(Server.MapPath("~/temp/"), UserImageUrlUpload.FileName);
                Helper.UploadFile(UserImageUrlUpload,strFilename);
                myImageBinary = Helper.GetImage(strFilename, System.Drawing.Imaging.ImageFormat.Jpeg, 160, 200);
            }
            catch
            {
            }

            try
            {
                AppUser myUser = new AppUser();

                myUser.LoginName = myModel.LoginName;
                myUser.ThumbnailPhoto = myImageBinary;
                myUser.Enabled = false;
                myUser.UserDs = myModel.UserDs;
                myUser.Email = myModel.Email;
                myUser.Phone = myModel.Phone;
                myUser.Password = myModel.Password;

                Guid g = Guid.NewGuid();                
                string s1 = g.ToString();



                if (myUser.LoginName == null)
                    myUser.LoginName = s1;
                if (myUser.Email == null)
                    myUser.Email = s1;
                if (myUser.Phone == null)
                    myUser.Phone = s1;


                db.AppUser.Add(myUser);
                int n = db.SaveChanges();

            }

            catch (Exception ex)
            {
                strRes = MessageModel.GetErrorMessage(ex);                
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Error", Title = "خطا", SubTitle = "",  MessageBody = strRes, BackUrl = "~/Account/SignUp" } );
            }

            return RedirectToAction("index","home");
        }

        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }

        //
     

        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

     
 

        [AllowAnonymous]
        public ActionResult LogOff()
        {
            Session[GlobalModule.m_CurrentUser] = new AppUserView { LoginName = "guest", UserRole = (int)UserRoleEnum.GUEST };
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
          
            }

            base.Dispose(disposing);
        }

        [AllowAnonymous]
        public ActionResult AppUserList()
        {
            if (((footballcup.Models.AppUserView)Session[CommonUnit.GlobalModule.m_CurrentUser]).UserRole == (int)UserRoleEnum.GUEST)
            {
                return RedirectToAction("HandleMessage", "Home", new MessageModel { MessageType = "Warning", Title = "اخطار", SubTitle = "کاربر نامعتبر", MessageBody = "شما به این گزینه دسترسی ندارید", BackUrl = "~/" });
            }
            else

                ViewBag.CompetitorList = Session[GlobalModule.m_CompetitorList];


            return View();

        }

    


    #region Helpers
    // Used for XSRF protection when adding external logins
    private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }




        }

        #endregion
    }
}