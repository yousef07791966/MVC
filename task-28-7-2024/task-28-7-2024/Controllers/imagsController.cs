using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using task_28_7_2024.Models;

namespace task_28_7_2024.Controllers
{
    public class imagsController : Controller
    {
        private ausiiEntities db = new ausiiEntities();

        // GET: imags
        public ActionResult Index()
        {
            return View(db.imags.ToList());
        }

        // GET: imags/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            imag imag = db.imags.Find(id);
            if (imag == null)
            {
                return HttpNotFound();
            }
            return View(imag);
        }

        // GET: imags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: imags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,email,image,age")] imag imag)
        {
            if (ModelState.IsValid)
            {
                db.imags.Add(imag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(imag);
        }

        // GET: imags/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            imag imag = db.imags.Find(id);
            if (imag == null)
            {
                return HttpNotFound();
            }
            return View(imag);
        }

        // POST: imags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,email,image,age")] imag imag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(imag);
        }

        // GET: imags/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            imag imag = db.imags.Find(id);
            if (imag == null)
            {
                return HttpNotFound();
            }
            return View(imag);
        }

        // POST: imags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            imag imag = db.imags.Find(id);
            db.imags.Remove(imag);
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
