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
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
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

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                var today = DateTime.Today;
                int userAge = today.Year - insuree.DateOfBirth.Year;
                double quote = 50;
                if (userAge < 19)
                {
                    quote = quote + 100;
                }
                else if (userAge > 18 && userAge < 26)
                {
                    quote = quote + 50;
                }
                else if (userAge > 25)
                {
                    quote = quote + 25;
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote = quote + 25;
                }
                if (insuree.CarMake == "porsche")
                {
                    quote = quote + 25;
                }
                if (insuree.CarModel == "911 carrera")
                {
                    quote = quote + 25;
                }

                double speedingTicketCost = insuree.SpeedingTickets * 10;
                quote = quote + speedingTicketCost;

                if (insuree.DUI == true)
                {
                    quote = quote + (quote * 0.25);
                }
                if (insuree.CoverageType == true)
                {
                    quote = quote + (quote * 0.50);
                }
                Convert.ToDecimal(quote);
                insuree.Quote = (decimal)quote;
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
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

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                var today = DateTime.Today;
                int userAge = today.Year - insuree.DateOfBirth.Year;
                double quote = 50;
                if (userAge < 19)
                {
                    quote = quote + 100;
                }
                else if (userAge > 18 && userAge < 26)
                {
                    quote = quote + 50;
                }
                else if (userAge > 25)
                {
                    quote = quote + 25;
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote = quote + 25;
                }
                if (insuree.CarMake == "porsche")
                {
                    quote = quote + 25;
                }
                if (insuree.CarModel == "911 carrera")
                {
                    quote = quote + 25;
                }

                double speedingTicketCost = insuree.SpeedingTickets * 10;
                quote = quote + speedingTicketCost;

                if (insuree.DUI == true)
                {
                    quote = quote + (quote * 0.25);
                }
                if (insuree.CoverageType == true)
                {
                    quote = quote + (quote * 0.50);
                }
                Convert.ToDecimal(quote);
                insuree.Quote = (decimal)quote;
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
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

        // POST: Insuree/Delete/5
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
