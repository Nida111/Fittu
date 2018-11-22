using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bookyourdoctor;

namespace bookyourdoctor.Controllers
{
    public class Clinic_requestController : Controller
    {
        private FINALEntities db = new FINALEntities();

        // GET: Clinic_request
        public ActionResult Index()
        {
            return View(db.Clinic_request.ToList());
        }

        // GET: Clinic_request/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinic_request clinic_request = db.Clinic_request.Find(id);
            if (clinic_request == null)
            {
                return HttpNotFound();
            }
            return View(clinic_request);
        }

        // GET: Clinic_request/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clinic_request/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "c_req_id,Clinic_time,date,patient_name,clinic_day,Accept,Reject")] Clinic_request clinic_request)
        {
            if (ModelState.IsValid)
            {
                db.Clinic_request.Add(clinic_request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clinic_request);
        }

        // GET: Clinic_request/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinic_request clinic_request = db.Clinic_request.Find(id);
            if (clinic_request == null)
            {
                return HttpNotFound();
            }
            return View(clinic_request);
        }

        // POST: Clinic_request/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "c_req_id,Clinic_time,date,patient_name,clinic_day,Accept,Reject")] Clinic_request clinic_request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clinic_request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clinic_request);
        }

        // GET: Clinic_request/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinic_request clinic_request = db.Clinic_request.Find(id);
            if (clinic_request == null)
            {
                return HttpNotFound();
            }
            return View(clinic_request);
        }

        // POST: Clinic_request/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Clinic_request clinic_request = db.Clinic_request.Find(id);
            db.Clinic_request.Remove(clinic_request);
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
