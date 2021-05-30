using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult _Services()
        {
            return PartialView();
        }
    }
}