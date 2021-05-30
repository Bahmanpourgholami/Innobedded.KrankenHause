using Innobedded.KrankenHause.Domain.UnitOfWork;
using Innobedded.KrankenHause.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Innobedded.KrankenHause.WebSite.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        UnitOfWork _unitOfWork;

        public AccountController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginview,string ReturnUrl="/")
        {
            if (ModelState.IsValid)
            {
                if(_unitOfWork.UserRepository.IsExsist(loginview.UserName,loginview.Password))
                {
                    
                    FormsAuthentication.SetAuthCookie(loginview.UserName, loginview.Remember);
                    return Redirect(ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError("UserName", "Username not found");
                }
                
            }
            
            
                return View(loginview);
            
        }
    }
}