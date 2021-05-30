using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult _AboutUs()
        {
            return PartialView();
        }
    }
}