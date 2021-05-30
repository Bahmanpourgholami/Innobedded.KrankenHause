using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Test()
        {

            return View("index");
        }


        [HttpGet]
        public ActionResult ChangeLanguage(string lan)
        {
            if (lan != null)
            {

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lan);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lan);
            }

            HttpCookie _languageCooki = new HttpCookie("SiteLanguage");
            _languageCooki.Value = lan;
            Response.Cookies.Add(_languageCooki);

            return Redirect("/");
        }
    }
}