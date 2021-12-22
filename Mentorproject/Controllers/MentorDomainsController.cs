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
    public class MentorDomainsController : Controller
    {
        private MentorInformationDBaseEntities1 db = new MentorInformationDBaseEntities1();

        // GET: MentorDomains
        public ActionResult Index()
        {
            return View(db.MentorDomains.ToList());
        }

        // GET: MentorDomains/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorDomain mentorDomain = db.MentorDomains.Find(id);
            if (mentorDomain == null)
            {
                return HttpNotFound();
            }
            return View(mentorDomain);
        }

        // GET: MentorDomains/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MentorDomains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DomainId,DomainName")] MentorDomain mentorDomain)
        {
            if (ModelState.IsValid)
            {
                db.MentorDomains.Add(mentorDomain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mentorDomain);
        }

        // GET: MentorDomains/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorDomain mentorDomain = db.MentorDomains.Find(id);
            if (mentorDomain == null)
            {
                return HttpNotFound();
            }
            return View(mentorDomain);
        }

        // POST: MentorDomains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DomainId,DomainName")] MentorDomain mentorDomain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentorDomain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mentorDomain);
        }

        // GET: MentorDomains/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorDomain mentorDomain = db.MentorDomains.Find(id);
            if (mentorDomain == null)
            {
                return HttpNotFound();
            }
            return View(mentorDomain);
        }

        // POST: MentorDomains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MentorDomain mentorDomain = db.MentorDomains.Find(id);
            db.MentorDomains.Remove(mentorDomain);
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
