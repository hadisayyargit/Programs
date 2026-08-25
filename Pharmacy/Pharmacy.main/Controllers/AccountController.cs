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
using pharmacy.Models;
using pharmacy.Helper;

namespace pharmacy.Controllers
{

    public class AccountController : Controller
    {
        //// GET: Account
        //// GET: /Account/Login
        //[AllowAnonymous]
        //public ActionResult Login(string returnUrl)
        //{
        //    ViewBag.ReturnUrl = returnUrl;
        //    return View();
        //}

        private pharmacyDbContext db = new pharmacyDbContext();

        [AllowAnonymous]
        public async Task<ActionResult> Authenticate(LoginViewModel model, string returnUrl)
        {
            AppUser user = new AppUser { LoginName = "guest", UserRole= (int)UserRoleEnum.GUEST, UserDs = "کاربر مهمان", UserId = 0 };


            if (ModelState.IsValid)
            {

                string strPassHash = "";
                try
                {
                    user = db.AppUser.Where(m => m.LoginName == model.UserName).FirstOrDefault();

                    strPassHash = user.Password;

                    //if (model.Password.GetHashCode().ToString() == strPassHash)
                    if (model.Password == strPassHash)
                    {
                        Session[GeneralModule.m_CurrentUser] = user;
                    }
                }
                catch
                {
                }

            }
   

            return RedirectToAction("Index", "Home");
        }


        [AllowAnonymous]
        public ActionResult LogIn()
        {
            Session[GeneralModule.m_CurrentUser] = new AppUser { LoginName = "guest", UserRole = (int)UserRoleEnum.GUEST, UserDs = "کاربر مهمان", UserId = 0 };
            return View();
        }

        public ActionResult LogOff()
        {
            Session[GeneralModule.m_CurrentUser] = new AppUser { LoginName = "guest", UserRole = (int)UserRoleEnum.GUEST, UserDs = "کاربر مهمان", UserId = 0 };

            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }



        // GET: /Account/ResetPassword
        [AllowAnonymous]
        public ActionResult ResetPassword(string code)
        {
            return code == null ? View("Error") : View();
        }



        //
        // GET: /Account/ResetPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ResetPasswordConfirmation()
        {
            return View();
        }





    }
}