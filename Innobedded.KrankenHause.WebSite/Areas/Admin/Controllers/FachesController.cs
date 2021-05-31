using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Innobedded.KrankenHause.Data.Context;
using Innobedded.KrankenHause.Data.Entities;
using Innobedded.KrankenHause.Domain.UnitOfWork;

namespace Innobedded.KrankenHause.WebSite.Areas.Admin.Controllers
{
    [Authorize]
    public class FachesController : Controller
    {
        //private KrankenHausDbContext db = new KrankenHausDbContext();
        private UnitOfWork _unitofwork;
        public FachesController()
        {
            _unitofwork = new UnitOfWork();
        }

        // GET: Admin/Faches

        
        public ActionResult Index()
        {
            //return View(db.Faches.ToList());
            return PartialView(_unitofwork.FachRepository.GetAll());
        }

        // GET: Admin/Faches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Fach fach = db.Faches.Find(id);
            Fach fach = _unitofwork.FachRepository.GetById(id);
            if (fach == null)
            {
                return HttpNotFound();
            }
            return View(fach);
        }

        // GET: Admin/Faches/Create
        public ActionResult Create()
        {
            return View();
        }

     

        // POST: Admin/Faches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FachID,Title")] Fach fach)
        {
            if (ModelState.IsValid)
            {
                //db.Faches.Add(fach);
                //db.SaveChanges();
                _unitofwork.FachRepository.Insert(fach);
                _unitofwork.FachRepository.Save();
                return View(fach);
            }

            return View(fach);
        }

        // GET: Admin/Faches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Fach fach = db.Faches.Find(id);
            Fach fach = _unitofwork.FachRepository.GetById(id);
            if (fach == null)
            {
                return HttpNotFound();
            }
            return View(fach);
        }

        // POST: Admin/Faches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FachID,Title")] Fach fach)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(fach).State = EntityState.Modified;
                //db.SaveChanges();
                _unitofwork.FachRepository.Update(fach);
                _unitofwork.FachRepository.Save();
                return RedirectToAction("Index");
            }
            return View(fach);
        }

        // GET: Admin/Faches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fach fach = _unitofwork.FachRepository.GetById(id);
            if (fach == null)
            {
                return HttpNotFound();
            }
            return View(fach);
        }

        // POST: Admin/Faches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fach fach = _unitofwork.FachRepository.GetById(id);
            _unitofwork.FachRepository.Delete(fach);
            _unitofwork.FachRepository.Save();
            
            return RedirectToAction("Index");
        }

        public ActionResult SpecialFach(string fach)
        {
            fach = "test";
            var Temp = _unitofwork.FachRepository.GetSpecialFach(fach);
            if (Temp == null)
            {
                HttpNotFound();
            }
            else
            return View(Temp);

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitofwork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
