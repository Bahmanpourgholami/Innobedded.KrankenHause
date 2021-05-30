using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class ClinicsController : Controller
    {
        // GET: Clinics
        public ActionResult _Clinics()
        {
            return PartialView();
        }
    }
}