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
    public class FacultyCoursesController : Controller
    {
        private FYPManagementContext db = new FYPManagementContext();

        // GET: FacultyCourses
        public ActionResult Index()
        {
            var facultyCourses = db.FacultyCourses.Include(f => f.courseObj).Include(f => f.supervisorObj);
            return View(facultyCourses.ToList());
        }

        // GET: FacultyCourses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacultyCourse facultyCourse = db.FacultyCourses.Find(id);
            if (facultyCourse == null)
            {
                return HttpNotFound();
            }
            return View(facultyCourse);
        }

        // GET: FacultyCourses/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Code");
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name");
            return View();
        }

        // POST: FacultyCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SupervisorID,CourseID")] FacultyCourse facultyCourse)
        {
            if (ModelState.IsValid)
            {
                db.FacultyCourses.Add(facultyCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Code", facultyCourse.CourseID);
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name", facultyCourse.SupervisorID);
            return View(facultyCourse);
        }

        // GET: FacultyCourses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacultyCourse facultyCourse = db.FacultyCourses.Find(id);
            if (facultyCourse == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Code", facultyCourse.CourseID);
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name", facultyCourse.SupervisorID);
            return View(facultyCourse);
        }

        // POST: FacultyCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SupervisorID,CourseID")] FacultyCourse facultyCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facultyCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Code", facultyCourse.CourseID);
            ViewBag.SupervisorID = new SelectList(db.Supervisors, "ID", "Name", facultyCourse.SupervisorID);
            return View(facultyCourse);
        }

        // GET: FacultyCourses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacultyCourse facultyCourse = db.FacultyCourses.Find(id);
            if (facultyCourse == null)
            {
                return HttpNotFound();
            }
            return View(facultyCourse);
        }

        // POST: FacultyCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FacultyCourse facultyCourse = db.FacultyCourses.Find(id);
            db.FacultyCourses.Remove(facultyCourse);
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
