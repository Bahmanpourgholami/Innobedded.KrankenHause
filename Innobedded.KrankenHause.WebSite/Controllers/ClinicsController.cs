using Innobedded.KrankenHause.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class ClinicsController : Controller
    {
        UnitOfWork _unitOfwork;

        public ClinicsController()
        {
            _unitOfwork = new UnitOfWork();
        }
        public ActionResult _Clinics()
        {
            return PartialView();
        }
    }
}