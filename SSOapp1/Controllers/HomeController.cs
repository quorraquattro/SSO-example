using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using SSOapp1.Models;

namespace SSOapp1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            var vm = new IndexVm();

            if (Session["LoggedIn"] == null)
                vm.IsLoginSuccessful = false;
            else
                vm.IsLoginSuccessful = true;

            return View(vm);
        }
        
        [HttpPost]
        public ActionResult Index(IndexVm vm)
        {
            const string cookieName = "loginAllowed";
            var loginAllowedCookie = new HttpCookie(cookieName);

            if (vm.UserName == "serge")
            {
                vm.IsLoginSuccessful = true;

                //add cookie. we can also add MAC guid, random number, name could be encrypted etc
                loginAllowedCookie.Values["UserName"] = vm.UserName;
                loginAllowedCookie.Expires = DateTime.Now.AddMinutes(2);
                System.Web.HttpContext.Current.Response.Cookies.Add(loginAllowedCookie);
            }
            else
            {
                vm.IsLoginSuccessful = false;
                vm.UnsuccesfullAttemptToLogin = true;
                vm.UserName = String.Empty;
                loginAllowedCookie.Expires = DateTime.Now.AddDays(-1);
                System.Web.HttpContext.Current.Response.Cookies.Add(loginAllowedCookie);
                System.Web.HttpContext.Current.Response.Cookies.Remove(cookieName);
            }

            
            

            return View(vm);
        }


    }
}
