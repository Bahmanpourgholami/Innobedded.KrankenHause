using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class DoctorsController : Controller
    {
        // GET: Doctors
        public ActionResult _Doctors()
        {
            //ViewBag.d = "Heeerrri";
            return PartialView();
        }
    }
}