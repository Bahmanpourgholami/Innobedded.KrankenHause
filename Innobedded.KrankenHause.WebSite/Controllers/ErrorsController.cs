using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Error
        public ActionResult Error404()
        {
            return View();
        }
    }
}