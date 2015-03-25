using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSOapp2.Models;

namespace SSOapp2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var vm = new Index2Vm();

            //try to find login cookie
            const string cookieName = "loginAllowed";
            bool isLoginCookieExists = HttpContext.Request.Cookies[cookieName] != null;
            if (isLoginCookieExists)
            {
                HttpCookie loginCheckCookie = HttpContext.Request.Cookies.Get(cookieName);
                vm.IsLoginCookieExists = true;
                vm.UserName = loginCheckCookie.Values["UserName"];
            }
            else
            {
                vm.IsLoginCookieExists = false;
            }

            return View(vm);
        }

    }
}
