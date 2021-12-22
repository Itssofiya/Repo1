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
    public class MentorProfilesController : Controller
    {
        private MentorInformationDBaseEntities1 db = new MentorInformationDBaseEntities1();

        // GET: MentorProfiles
        public ActionResult Index()
        {
            return View(db.MentorProfiles.ToList());
        }

        // GET: MentorProfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorProfile mentorProfile = db.MentorProfiles.Find(id);
            if (mentorProfile == null)
            {
                return HttpNotFound();
            }
            return View(mentorProfile);
        }

        // GET: MentorProfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MentorProfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MentorId,DomainId,IndustryExperience,MentoringExperience,Skills,AvailableFrom,AvailableTo")] MentorProfile mentorProfile)
        {
            if (ModelState.IsValid)
            {
                db.MentorProfiles.Add(mentorProfile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mentorProfile);
        }

        // GET: MentorProfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorProfile mentorProfile = db.MentorProfiles.Find(id);
            if (mentorProfile == null)
            {
                return HttpNotFound();
            }
            return View(mentorProfile);
        }

        // POST: MentorProfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MentorId,DomainId,IndustryExperience,MentoringExperience,Skills,AvailableFrom,AvailableTo")] MentorProfile mentorProfile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentorProfile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mentorProfile);
        }

        // GET: MentorProfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorProfile mentorProfile = db.MentorProfiles.Find(id);
            if (mentorProfile == null)
            {
                return HttpNotFound();
            }
            return View(mentorProfile);
        }

        // POST: MentorProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MentorProfile mentorProfile = db.MentorProfiles.Find(id);
            db.MentorProfiles.Remove(mentorProfile);
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
