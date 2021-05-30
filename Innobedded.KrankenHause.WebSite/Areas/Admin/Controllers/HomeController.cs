using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Innobedded.KrankenHause.WebSite.Areas.Admin.Controllers
{

    [Authorize]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            


            return View();
        }

        [HttpGet]
        public ActionResult ShowBlock(string input)
        {
            ViewBag.Kir = "HOOOOY" + input;
            return PartialView("_Blocks");
            //return RedirectToAction("Index", "Faches");
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            return RedirectToAction("login","account");
        }
    }
}