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
            Test();
            return View();
        }

        public ActionResult Test()
        {
            //ChangeLanguage("fa");
            return Redirect("www.google.com");
        }



        /// <summary>
        /// Change WebSite Language and save as Cooki in User Broweser
        /// </summary>
        /// <param name="lan"></param>
        /// <returns></returns>
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