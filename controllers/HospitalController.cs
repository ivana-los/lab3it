using mvccc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace mvccc.Controllers
{
    public class HospitalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public static Hospital hospital = new Hospital() { ImageUrl = @"https://static.vecteezy.com/system/resources/thumbnails/038/252/707/small_2x/hospital-building-illustration-medical-clinic-isolated-on-white-background-vector.jpg" };
        // GET: Hospital
        public ActionResult Index()
        {
            return View(db.Hospitals.ToList());
        }

        // GET: Hospital/Details/5
        public ActionResult Details(int ? id)
        {
            if( id == null)
            {
                return new  HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            Hospital hospital = db.Hospitals.Find(id);
            if(hospital == null)
            {
                return HttpNotFound();
            }
            return View(hospital);
        }

        // GET: Hospital/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospital/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Name")] Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                db.Hospitals.Add(hospital);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospital);
        }

        // GET: Hospital/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital hospital = db.Hospitals.Find(id);
            if (hospital == null)
            {
                return HttpNotFound();
            }
            return View(hospital);
        }

        // POST: Hospital/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name")] Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospital).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospital);
        }

        // GET: Hospitals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital hospital = db.Hospitals.Find(id);
            if (hospital == null)
            {
                return HttpNotFound();
            }
            return View(hospital);
        }

        // POST: Hospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hospital hospital = db.Hospitals.Find(id);
            db.Hospitals.Remove(hospital);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
