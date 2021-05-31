using Innobedded.KrankenHause.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class ServicesController : Controller
    {
        UnitOfWork _unitofwork;
        public ServicesController()
        {
            _unitofwork = new UnitOfWork();
        }
        public ActionResult _Services()
        {
            return PartialView(_unitofwork.klinikServicesRepository.GetAll());
        }


        
        public ActionResult ServiceDetails(int? id)
        {
            return View(_unitofwork.klinikServicesRepository.GetById(id));
        }

    }
}