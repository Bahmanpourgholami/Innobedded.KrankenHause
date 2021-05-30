using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult _Appointments()
        {
            return PartialView();
        }
    }
}