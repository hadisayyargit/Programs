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
using shahriarco.Anbar.Models;
using System.Web.Security;
using shahriarco.CommonUnit;

namespace shahriarco.Anbar.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        //private ApplicationSignInManager _signInManager;
        //private ApplicationUserManager _userManager;


        AnbarEntities db = new AnbarEntities();
        public AccountController()
        {
        }



        [AllowAnonymous]
        public ActionResult UserProfile()
        {
            TUser myUser = (TUser)Session[GeneralModule.m_CurrentUser];
            return View(myUser);
        }

        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        // POST: /Account/Login
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Authenticate(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }

            //User.Identity.IsAuthenticated
            try
            {
                TUser user = db.TUser.Where(u => u.LoginName == model.UserName).FirstOrDefault();

                Session[GeneralModule.m_CurrentUser] = user;
            }
            catch(Exception ex)
            {
                Session[GeneralModule.m_CurrentUser] = null;
            }

            return RedirectToAction("Index", "Home");

        }

  
     
    }
}