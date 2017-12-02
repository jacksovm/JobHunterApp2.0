using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobHunterApp.Models;

namespace JobHunterApp.Controllers
{
    public class StarsController : Controller
    {
        private JobHunterDBEntities1 db = new JobHunterDBEntities1();

        // GET: Stars
        public ActionResult Index()
        {
            return View(db.Stars.ToList());
        }

        // GET: Stars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Star star = db.Stars.Find(id);
            if (star == null)
            {
                return HttpNotFound();
            }
            return View(star);
        }

        // GET: Stars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StarsID,StarAmount")] Star star)
        {
            if (ModelState.IsValid)
            {
                db.Stars.Add(star);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(star);
        }

        // GET: Stars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Star star = db.Stars.Find(id);
            if (star == null)
            {
                return HttpNotFound();
            }
            return View(star);
        }

        // POST: Stars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StarsID,StarAmount")] Star star)
        {
            if (ModelState.IsValid)
            {
                db.Entry(star).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(star);
        }

        // GET: Stars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Star star = db.Stars.Find(id);
            if (star == null)
            {
                return HttpNotFound();
            }
            return View(star);
        }

        // POST: Stars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Star star = db.Stars.Find(id);
            db.Stars.Remove(star);
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
