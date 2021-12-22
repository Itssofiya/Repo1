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
    public class LoginController : Controller
    {
        private MentorInformationDBaseEntities1 db = new MentorInformationDBaseEntities1();

        // GET: Login
        public ActionResult Index()
        {
            return View(db.MentorRegistrations.ToList());
        }

        // GET: Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MentorRegistration mentorRegistration = db.MentorRegistrations.Find(id);
            if (mentorRegistration == null)
            {
                return HttpNotFound();
            }
            return View(mentorRegistration);
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }
         

        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Username,Passsword")] MentorRegistration mentorRegistration)
        {
            if (ModelState.IsValid)
            {
                if (mentorRegistration.Username == "Sofiya" && mentorRegistration.Passsword == "Sofiya123") 
                {
                    return RedirectToAction("Index", "MentorProfiles");
                    
                }
                else
                {
                    return RedirectToAction("Create", "MentorRegistrations");
                }
                db.MentorRegistrations.Add(mentorRegistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mentorRegistration);
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
