using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using ShakelliReportsUI.DataLayer.Models;
using ShakelliReportsUI.CommonUnits;
using ShakelliReportsUI.DataLayer;
using System.IO;

using System.Drawing;
using System.Data.Entity;
using System.Diagnostics;
using System.Reflection;


namespace ShakelliReportsUI.Main.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ShakelliDWEntities db = new ShakelliDWEntities();

        public AccountController()
            : this(new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext())))
        {
        }

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    ShakelliAuthentication objAuthentication = new ShakelliAuthentication();
                    string strAutenticateResult = objAuthentication.AuthenticateUser(model.UserName, model.Password);

                    HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserId] = null;
                    HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] = null;
                    HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonName] = null;
                    HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonCode] = null;
                    HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonId] = null;
                    HttpContext.Session[CommonUnits.GeneralModule.m_PersonImagePath] = null; 

                    if (strAutenticateResult.ToUpper() == "OK")
                    {
                        Session[CommonUnits.GeneralModule.m_CurrentUserName] = model.UserName;
                        Session[CommonUnits.GeneralModule.m_SessionTime] = DateTime.Now.ToString();
                        AppUser myuser = db.AppUser.Where(AppUser => AppUser.UserName == model.UserName).First();
                        HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserId] = myuser.UserId;
                        HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserType] = myuser.UserType;

                        
                        try
                        {
                            Session[CommonUnits.GeneralModule.m_CurrentGroupId] = db.AppGroupUser.Where(a => a.UserId == myuser.UserId).First().GroupId;
                        }
                        catch
                        {
                            Session[CommonUnits.GeneralModule.m_CurrentGroupId] = 0;

                        }

                        try
                        {
                            int? nPersonId = myuser.PersonId;
                            Person myPerson = db.Person.Where(a => a.PersonId == nPersonId).First();
                            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonName] = myPerson.FirstName + " " + myPerson.LastName;
                            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonCode] = myPerson.PersonCode;
                            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonId] = myPerson.PersonId;
                            HttpContext.Session[CommonUnits.GeneralModule.m_PersonImagePath] = GetImage(myPerson.PersonId);
                        }
                        catch
                        {

                        }

                        try
                        {
                            List<AppGroupUserObjectView> myAccessList;

                            if (model.UserName.ToLower() == "admin")
                            {
                                Session[CommonUnits.GeneralModule.m_CurrentPersonName] = "راهبر";
                                HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonCode] = null;
                                myAccessList = (from o in db.AppObject
                                                where (o.ObjectTypeCode == 1)
                                                select new AppGroupUserObjectView
                                                {
                                                    ObjectId = o.ObjectId,
                                                    ObjectDs = o.ObjectDs,
                                                    ObjectName = o.ObjectName,
                                                    ParentObjectId = o.ParentObjectId,
                                                    UrlPath = o.UrlPath,
                                                    HasDirectPath = o.HasDirectPath,
                                                    HasOwnGrid = o.HasOwnGrid,
                                                    HasServerReport = o.HasServerReport,

                                                    CRUD = "1111"
                                                }).ToList();
                            }

                            else
                            {
                                myAccessList = db.Database.SqlQuery<AppGroupUserObjectView>("spGetAccessRight @userid = {0}", new object[] { Session[CommonUnits.GeneralModule.m_CurrentUserId] }).ToList();
                            }


                            Session[CommonUnits.GeneralModule.m_AccessList] = myAccessList;

                            Session[CommonUnits.GeneralModule.m_MenuLevel1] = myAccessList.Where(m => m.ParentObjectId == null).Where(m => m.CRUD.Substring(1, 1) == "1").OrderBy(m => m.ParentObjectId).ThenBy(m=>m.ObjectId).ToList();

                            

                            Session[CommonUnits.GeneralModule.m_PrimeVisible] = myAccessList.Where(m => m.ObjectId == 1).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;
                            Session[CommonUnits.GeneralModule.m_SaleVisible] = myAccessList.Where(m => m.ObjectId == 2).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;
                            Session[CommonUnits.GeneralModule.m_MaterialVisible] = myAccessList.Where(m => m.ObjectId == 3).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;
                            Session[CommonUnits.GeneralModule.m_FinanceVisible] = myAccessList.Where(m => m.ObjectId == 4).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;
                            Session[CommonUnits.GeneralModule.m_BookOfAccountsVisible] = myAccessList.Where(m => m.ObjectId == 5).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;
                            Session[CommonUnits.GeneralModule.m_SmartReportsVisible] = myAccessList.Where(m => m.ObjectId == 6).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;

                            ///<todo>
                            ///
                            Session[CommonUnits.GeneralModule.m_ReportGeneratorVisible] = true;

                            Session[CommonUnits.GeneralModule.m_AdministrationVisible] = myAccessList.Where(m => m.ObjectId == 7).Where(m => m.CRUD.Substring(1, 1) == "1").ToList().Count > 0;

                            Session[CommonUnits.GeneralModule.m_MenuList_Prime] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 1).ToList();
                            Session[CommonUnits.GeneralModule.m_MenuList_Sale] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 2).ToList();
                            Session[CommonUnits.GeneralModule.m_MenuList_Material] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 3).ToList();
                            Session[CommonUnits.GeneralModule.m_MenuList_Finance] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 4).ToList();
                            Session[CommonUnits.GeneralModule.m_MenuList_BookOfAccounts] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 5).ToList();
                            Session[CommonUnits.GeneralModule.m_MenuList_SmartReports] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 6).ToList();
                            Session[CommonUnits.GeneralModule.m_MenuList_Administration] = myAccessList.Where(AppObject => AppObject.ParentObjectId == 7).ToList();
                        }
                        catch
                        {

                        }

                        Session[CommonUnits.GeneralModule.m_StoredProcedureParameterList] = db.Database.SqlQuery<ReportModel>("select [SPECIFIC_NAME] as StoredProcedure,[PARAMETER_NAME] as StoredProcedureParameterName,[DATA_TYPE] as StoredProcedureParameterType  from information_schema.parameters").ToList();


                        return RedirectToAction("Index", "Home");


                        //HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUser] = model.UserNo;
                        //HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonName] = myUser.UserDs;
                    }

                        ///بطور موقت
                    else
                    {
                        model.Message = strAutenticateResult;

                    }

                }
                catch (Exception ex)
                {
                    model.Message = ex.Message;
                }

            }
            else
            {
                model.Message = "";
            }


            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] = null;
            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserId] = null;
            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonName] = null;
            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonCode] = null;
            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentPersonId] = null;
            HttpContext.Session[CommonUnits.GeneralModule.m_PersonImagePath] = null;

            return View(model);

        }

        [AllowAnonymous]
        public ActionResult PersonEdit(int userid = 0)
        {
            AppUserPersonView myModel = new AppUserPersonView();

            Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_MessageModel] = null;

            if (userid == 0)
                userid = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]);


            myModel =
                 (from u in db.AppUser
                  join p in db.Person on u.PersonId equals p.PersonId into g2
                  orderby u.UserId
                  from up in g2.DefaultIfEmpty()
                  select new AppUserPersonView
                  {
                      UserId = u.UserId,
                      UserName = u.UserName,
                      PersonId = u.PersonId,
                      Password = u.Password,
                      OrganizationId = u.OrganizationId,
                      Enabled = u.Enabled,
                      EnabledTitle = (u.Enabled) ? "فعال" : "غیرفعال",
                      LastName = (up.LastName == null ? "" : up.LastName),
                      FirstName = (up.FirstName == null ? "" : up.FirstName)
                      ,
                      Address = up.Address
                      ,
                      PersonCode = up.PersonCode
                      ,
                      Email = up.Email
                      ,
                      Mobile = up.Mobile
                      ,
                      NationalCode = up.NationalCode
                      ,
                      Phone = up.Phone
                      ,
                      Photo = up.Photo
                  }).Where(a => a.UserId == userid).First();

            return View(myModel);
        }

        public string GetImage(int personid = 0)
        {
            string strPhysicalFilename = "",strServerFileName="";

            if (personid == 0)
                personid = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentPersonId]);

            string strPersoncode = "";
            Person myPerson = db.Person.Where(a => a.PersonId == personid).First();
            strPersoncode = myPerson.PersonCode;

            ///for testing
            db.Database.ExecuteSqlCommand("update person set  address={0} where PersonId={1}", "getting image", 1);

            try
            {
                strPhysicalFilename = Path.Combine(Server.MapPath("~/temp"), "p_" + strPersoncode)
                + ".jpg";

                strServerFileName = "~/temp/" + "p_" + strPersoncode + ".jpg";
                
                MemoryStream ms = new MemoryStream(myPerson.Photo);
                Image img1= Image.FromStream(ms);
                img1.Save(strPhysicalFilename, System.Drawing.Imaging.ImageFormat.Jpeg);

                db.Database.ExecuteSqlCommand("update person set  address={0} where PersonId={1}", "image saved", 1);
            }

            catch (Exception ex)
            {
                strServerFileName = "";
            }


            return strServerFileName;
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase UserImageUrlUpload, int personid = 0)
        {
            string strFilename = "";

           
            /// upload file
            if (personid == 0)
                personid = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentPersonId]);

            string strPersoncode = "";

            try
            {
                Person myPerson = db.Person.Where(a => a.PersonId == personid).First();
                strPersoncode = myPerson.PersonCode;
            }
            catch
            {
                ViewBag.Message = "پرسنل متناظر کاربر تعریف نشده است";
            }

            if (ViewBag.Message == "")
            {
                if (UserImageUrlUpload != null && UserImageUrlUpload.ContentLength > 0)
                {
                    try
                    {
                        strFilename = Path.Combine(Server.MapPath("~/Images"), "tmp_" + strPersoncode)
                                             + Path.GetExtension(UserImageUrlUpload.FileName);

                        UserImageUrlUpload.SaveAs(strFilename);
                        ViewBag.Message = "";

                        /// update at database
                        ViewBag.Message = UpdateImage(strFilename, personid);

                        ///Get Last Picture
                        GetImage();

                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    }
                }
                else
                {
                    ViewBag.Message = "You have not specified a file.";
                }

                try
                {
                    System.IO.File.Delete(strFilename);
                }
                catch
                {
                }
            }

            if (ViewBag.Message == "")
                return RedirectToAction("UserProfile", routeValues: new { userid = Session[CommonUnits.GeneralModule.m_CurrentUserId] });
            else
            {
                Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = ViewBag.Message, Title = "خطا", SubTitle = "خطا در بارگذاری تصویر", MessageType = "Error", CallerAction = "PersonEdit", CallerController = "Account" };
                Session[CommonUnits.GeneralModule.m_CurrentError] = null;
                return RedirectToAction("HandleError", "Home", Session[CommonUnits.GeneralModule.m_MessageModel]);

            }

        }
       
        public string UpdateImage(string strFilename, int userid=0)
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
                Person p = db.Person.Find(userid);
                p.Photo = bb;
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
            }

            catch(Exception ex)
            {
                strRes = ex.Message;
            }

            return strRes;
        }

        [AllowAnonymous]
        public ActionResult UserProfile(int userid = 0)
        {
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Home] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Prime] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Sale] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Material] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Finance] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Bookofaccounts] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Smartreports] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_ReportGenerator] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Administration] = "";
            Session[CommonUnits.GeneralModule.m_ActiveMenu_Help] = "active";

            AppUserPersonView myModel = new AppUserPersonView();

            Session[CommonUnits.GeneralModule.m_MessageModel] = null;

            if (userid == 0)
                userid = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]);


            myModel =
                 (from u in db.AppUser
                  join p in db.Person on u.PersonId equals p.PersonId into g2
                  orderby u.UserId
                  from up in g2.DefaultIfEmpty()
                  select new AppUserPersonView
                  {
                      UserId = u.UserId,
                      UserName = u.UserName,
                      PersonId = u.PersonId,
                      Password = u.Password,
                      OrganizationId = u.OrganizationId,
                      Enabled = u.Enabled,
                      EnabledTitle = (u.Enabled) ? "فعال" : "غیرفعال",
                      LastName = (up.LastName == null ? "" : up.LastName),
                      FirstName = (up.FirstName == null ? "" : up.FirstName)
                      ,
                      Address = up.Address
                      ,
                      PersonCode = up.PersonCode
                      ,
                      Email = up.Email
                      ,
                      Mobile = up.Mobile
                      ,
                      NationalCode = up.NationalCode
                      ,
                      Phone = up.Phone
                      ,Photo=up.Photo
                  }).Where(a => a.UserId == userid).First();

            
            return View(myModel);
        }

        [AllowAnonymous]
        public ActionResult ChangePassword(int userid)
        {
            ManageUserViewModel myModel = new ManageUserViewModel();

            if (userid == 0)
                userid = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]);

            myModel.UserId = userid;


            return View(myModel);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult ChangePassword(ManageUserViewModel myModel)
        {
            Session[ShakelliReportsUI.CommonUnits.GeneralModule.m_MessageModel] = null;

            if (ModelState.IsValid)
            {
                if (myModel.UserId == 0)
                    myModel.UserId = Convert.ToInt32(Session[CommonUnits.GeneralModule.m_CurrentUserId]);
                try
                {
                    db.Database.ExecuteSqlCommand("update AppUser Set Password={0} where userid={1}", myModel.Password, myModel.UserId);

                    Session[CommonUnits.GeneralModule.m_MessageModel] = new MessageModel { MessageBody = "گذرواژه تغییر کرد", Title = "", SubTitle = "عوض کردن رمز", MessageType = "Success", CallerAction = "UserProfile", CallerController = "Account" };
                    return RedirectToAction("ChangePassword", "Account", routeValues: new { userid = myModel.UserId });


                }
                catch (Exception ex)
                {

                    myModel.Message = ex.Message;
                }
            }
            else
            {

            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult LockScreen()
        {

            return View();
        }

        //
        // POST: /Account/LogOff
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut();



            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserId] = null;
            HttpContext.Session[CommonUnits.GeneralModule.m_CurrentUserName] = null;

            return RedirectToAction("Login", "Account");
            //return View("Login");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && UserManager != null)
            {
                UserManager.Dispose();
                UserManager = null;
            }
            base.Dispose(disposing);
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

        private bool HasPassword()
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                return user.PasswordHash != null;
            }
            return false;
        }

        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            Error
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        #endregion
    }
}