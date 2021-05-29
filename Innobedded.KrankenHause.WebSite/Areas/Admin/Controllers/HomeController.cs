using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
           
            return View();
        }


        public ActionResult ShowBlock()
        {
            ViewBag.Kir = "HOOOOY";
            return PartialView("_Blocks");
        }
    }
}