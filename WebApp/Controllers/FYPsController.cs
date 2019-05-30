using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FYPsController : Controller
    {
        private FYPManagementContext db = new FYPManagementContext();

        // GET: FYPs
        public ActionResult Index()
        {
            var fYPs = db.FYPs.Include(f => f.supervisorObj);
            return View(fYPs.ToList());
        }

        // GET: FYPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FYP fYP = db.FYPs.Find(id);
            if (fYP == null)
            {
                return HttpNotFound();
            }
            return View(fYP);
        }

        // GET: FYPs/Create
        public ActionResult Create()
        {
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name");
            return View();
        }

        // POST: FYPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Members,Description,SupervisorID")] FYP fYP)
        {
            if (ModelState.IsValid)
            {
                db.FYPs.Add(fYP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name", fYP.SupervisorID);
            return View(fYP);
        }

        // GET: FYPs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FYP fYP = db.FYPs.Find(id);
            if (fYP == null)
            {
                return HttpNotFound();
            }
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name", fYP.SupervisorID);
            return View(fYP);
        }

        // POST: FYPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Members,Description,SupervisorID")] FYP fYP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fYP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name", fYP.SupervisorID);
            return View(fYP);
        }

        // GET: FYPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FYP fYP = db.FYPs.Find(id);
            if (fYP == null)
            {
                return HttpNotFound();
            }
            return View(fYP);
        }

        // POST: FYPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FYP fYP = db.FYPs.Find(id);
            db.FYPs.Remove(fYP);
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
