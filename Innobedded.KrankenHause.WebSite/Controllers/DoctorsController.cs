using Innobedded.KrankenHause.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class DoctorsController : Controller
    {
        UnitOfWork _unitofwork;
        public DoctorsController()
        {
            _unitofwork = new UnitOfWork();
        }


        public ActionResult _Doctors()
        {
            //ViewBag.d = "Heeerrri";


            return PartialView(_unitofwork.DoctorRepository.doctorsViewModels());
        }
    }
}