using Innobedded.KrankenHause.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class AppointmentController : Controller
    {
        UnitOfWork _unitofwork;
        public AppointmentController()
        {
            _unitofwork = new UnitOfWork();
        }
        public ActionResult _Appointments()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult SetAppointment(string name, string email,DateTime mydate, string phone,string message) {
            string mymessage = "";
            var heute = DateTime.Now.Date;

            if (mydate >= heute)
            {

                _unitofwork.AppointmentRepository.Insert(new Data.Entities.Appointment()
                {
                    Email=email,
                    Description=message,
                    FullName=name,
                    ReserveDate=mydate,
                    Telefon=phone
                });
                _unitofwork.AppointmentRepository.Save();
                _unitofwork.Commit();
                mymessage = "Success ! we Send you Email... Please Check Inbox or Spam email";
            }
            else
            {
                mymessage = "Date is inValid";
            }

            return Content(mymessage);

            //return Redirect(name);
        }
    }
}