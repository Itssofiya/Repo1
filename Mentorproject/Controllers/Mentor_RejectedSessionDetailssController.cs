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
    public class Mentor_RejectedSessionDetailssController : Controller
    {
        private MentorInformationDBaseEntities1 db = new MentorInformationDBaseEntities1();

        // GET: Mentor_RejectedSessionDetailss
        public ActionResult Index()
        {
            return View(db.Mentor_RejectedSessionDetailss.ToList());
        }

        // GET: Mentor_RejectedSessionDetailss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor_RejectedSessionDetailss mentor_RejectedSessionDetailss = db.Mentor_RejectedSessionDetailss.Find(id);
            if (mentor_RejectedSessionDetailss == null)
            {
                return HttpNotFound();
            }
            return View(mentor_RejectedSessionDetailss);
        }

        // GET: Mentor_RejectedSessionDetailss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mentor_RejectedSessionDetailss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MentorId,DomainId,SessionId,SessionDate,RejectReason")] Mentor_RejectedSessionDetailss mentor_RejectedSessionDetailss)
        {
            if (ModelState.IsValid)
            {
                db.Mentor_RejectedSessionDetailss.Add(mentor_RejectedSessionDetailss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mentor_RejectedSessionDetailss);
        }

        // GET: Mentor_RejectedSessionDetailss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor_RejectedSessionDetailss mentor_RejectedSessionDetailss = db.Mentor_RejectedSessionDetailss.Find(id);
            if (mentor_RejectedSessionDetailss == null)
            {
                return HttpNotFound();
            }
            return View(mentor_RejectedSessionDetailss);
        }

        // POST: Mentor_RejectedSessionDetailss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MentorId,DomainId,SessionId,SessionDate,RejectReason")] Mentor_RejectedSessionDetailss mentor_RejectedSessionDetailss)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentor_RejectedSessionDetailss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mentor_RejectedSessionDetailss);
        }

        // GET: Mentor_RejectedSessionDetailss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mentor_RejectedSessionDetailss mentor_RejectedSessionDetailss = db.Mentor_RejectedSessionDetailss.Find(id);
            if (mentor_RejectedSessionDetailss == null)
            {
                return HttpNotFound();
            }
            return View(mentor_RejectedSessionDetailss);
        }

        // POST: Mentor_RejectedSessionDetailss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mentor_RejectedSessionDetailss mentor_RejectedSessionDetailss = db.Mentor_RejectedSessionDetailss.Find(id);
            db.Mentor_RejectedSessionDetailss.Remove(mentor_RejectedSessionDetailss);
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
