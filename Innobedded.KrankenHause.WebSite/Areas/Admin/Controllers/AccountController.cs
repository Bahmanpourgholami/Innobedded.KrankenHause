using Innobedded.KrankenHause.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Innobedded.KrankenHause.WebSite.Controllers
{
    public class AccountController : Controller
    {
        UnitOfWork unitOfWork;

        public AccountController()
        {
            unitOfWork = new UnitOfWork();
        }


        public ActionResult Login()
        {
            return View();
        }
    }
}