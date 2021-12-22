using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mentorproject;

namespace Mentorproject.Controllers
{
    public class Mentor_TakenSessionDetailsController : Controller
    {
        private MentorInformationDBaseEntities1 db = new MentorInformationDBaseEntities1();

        // GET: Mentor_TakenSessionDetails
        public ActionResult Index()
        {
            return View(db.Mentor_TakenSessionDetails.ToList());
        }

        // GET: Mentor_TakenSessionDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor_TakenSessionDetails mentor_TakenSessionDetails = db.Mentor_TakenSessionDetails.Find(id);
            if (mentor_TakenSessionDetails == null)
            {
                return HttpNotFound();
            }
            return View(mentor_TakenSessionDetails);
        }

        // GET: Mentor_TakenSessionDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mentor_TakenSessionDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MentorId,DomainId,AttendeesCount,SessionId,SessionDate,SessionStart,SessionEnd,SessionAmount")] Mentor_TakenSessionDetails mentor_TakenSessionDetails)
        {
            if (ModelState.IsValid)
            {
                db.Mentor_TakenSessionDetails.Add(mentor_TakenSessionDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mentor_TakenSessionDetails);
        }

        // GET: Mentor_TakenSessionDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor_TakenSessionDetails mentor_TakenSessionDetails = db.Mentor_TakenSessionDetails.Find(id);
            if (mentor_TakenSessionDetails == null)
            {
                return HttpNotFound();
            }
            return View(mentor_TakenSessionDetails);
        }

        // POST: Mentor_TakenSessionDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MentorId,DomainId,AttendeesCount,SessionId,SessionDate,SessionStart,SessionEnd,SessionAmount")] Mentor_TakenSessionDetails mentor_TakenSessionDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentor_TakenSessionDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mentor_TakenSessionDetails);
        }

        // GET: Mentor_TakenSessionDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor_TakenSessionDetails mentor_TakenSessionDetails = db.Mentor_TakenSessionDetails.Find(id);
            if (mentor_TakenSessionDetails == null)
            {
                return HttpNotFound();
            }
            return View(mentor_TakenSessionDetails);
        }

        // POST: Mentor_TakenSessionDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mentor_TakenSessionDetails mentor_TakenSessionDetails = db.Mentor_TakenSessionDetails.Find(id);
            db.Mentor_TakenSessionDetails.Remove(mentor_TakenSessionDetails);
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
