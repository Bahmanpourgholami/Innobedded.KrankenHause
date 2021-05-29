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

        [HttpGet]
        public ActionResult ShowBlock(string input)
        {
            ViewBag.Kir = "HOOOOY" + input;
            return PartialView("_Blocks");
            //return RedirectToAction("Index", "Faches");
        }
    }
}