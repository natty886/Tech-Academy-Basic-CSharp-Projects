using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insurees
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insurees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insurees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // 1a. Start with a base of $50 / month.
                insuree.Quote = 50m;
                // 1b. If the user is 18 or under, add $100 to the monthly total
                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
                {
                    insuree.Quote += 100;
                }
                // 1c. If the user is from 19 to 25, add $50 to the monthly total
                if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 19 && DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
                {
                    insuree.Quote += 50;
                }
                // 1d. If the user is 26 or older, add $25 to the monthly total
                if (DateTime.Now.Year - insuree.DateOfBirth.Year >= 26)
                {
                    insuree.Quote += 25;
                }
                // 1e. If the car's year is before 2000, add $25 to the monthly total
                if (DateTime.Now.Year - insuree.CarYear <= 2000) 
                {
                    insuree.Quote += 25;
                }
                // 1f. If the car's year is after 2015, add $25 to the monthly total
                if (DateTime.Now.Year - insuree.CarYear >= 2015)
                {
                    insuree.Quote += 25;
                }
                // 1g. If the car's Make is a Porsche, add $25 to the price
                if (insuree.CarMake == "Porsche")
                {
                    insuree.Quote += 25;
                }
                // 1h. If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                // 1i. Add $10 to the monthly total for every speeding ticket the user has
                if (insuree.SpeedingTickets > 0)
                {
                    insuree.Quote += (insuree.SpeedingTickets * 10);

                }
                // 1j. If the user has ever had a DUI, add 25% to the total
                if (insuree.DUI == true)
                {
                    insuree.Quote *= 1.25m;
                }
                // 1k. If it's full coverage, add 50% to the total
                if (insuree.CoverageType == true)
                {
                    insuree.Quote *= 1.5m;
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // 3. Add an Admin View for a site administrator to the Insuree Views
        public ActionResult Admin()
        {
           return View(db.Insurees.ToList());
        }


        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
