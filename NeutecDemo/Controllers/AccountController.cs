using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace NeutecDemo.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        UserManager userManager = new UserManager();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password, string returnUrl)
        {
            var user = userManager.ValidateUser(email, password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserMail, false);

                Session["UserRole"] = user.UserRole;
                TempData["SuccessMessage4"] = "Başarılı bir şekilde giriş yaptınız!";

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl); 
                }

                if (user.UserRole == "admin")
                {
                    return RedirectToAction("Index", "Product");
                }
                else if (user.UserRole == "dataEntry")
                {
                    return RedirectToAction("Index", "Product");
                }
                else if (user.UserRole == "dataViewer")
                {
                    return RedirectToAction("Index", "Product");
                }
            }   

            ViewBag.ErrorMessage = "Geçersiz email veya şifre";
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            TempData["LogoutMessage"] = "Başarılı bir şekilde çıkış yaptınız!";
            Session.Clear();
            return RedirectToAction("Login");
        }
    }

}