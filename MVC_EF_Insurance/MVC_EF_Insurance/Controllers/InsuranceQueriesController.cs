using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_EF_Insurance.DataAccessLayer;
using MVC_EF_Insurance.Models;

namespace MVC_EF_Insurance.Controllers
{
    public class InsuranceQueriesController : Controller
    {
        private InsuranceQueryContext db = new InsuranceQueryContext();

        // GET: InsuranceQueries
        public ActionResult Index()
        {
            return View(db.InsuranceQueries.ToList());
        }

        // GET: InsuranceQueries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceQuery insuranceQuery = db.InsuranceQueries.Find(id);
            if (insuranceQuery == null)
            {
                return HttpNotFound();
            }
            return View(insuranceQuery);
        }

        // GET: InsuranceQueries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceQueries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,firstName,lastName,email,birthdate,car_year,car_make,car_model,tickets,dui,coverage_full,calculated_rate")] InsuranceQuery insuranceQuery)
        {
            if (ModelState.IsValid)
            {
                db.InsuranceQueries.Add(insuranceQuery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuranceQuery);
        }

        // GET: InsuranceQueries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceQuery insuranceQuery = db.InsuranceQueries.Find(id);
            if (insuranceQuery == null)
            {
                return HttpNotFound();
            }
            return View(insuranceQuery);
        }

        // POST: InsuranceQueries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,firstName,lastName,email,birthdate,car_year,car_make,car_model,tickets,dui,coverage_full,calculated_rate")] InsuranceQuery insuranceQuery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuranceQuery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuranceQuery);
        }

        // GET: InsuranceQueries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceQuery insuranceQuery = db.InsuranceQueries.Find(id);
            if (insuranceQuery == null)
            {
                return HttpNotFound();
            }
            return View(insuranceQuery);
        }

        // POST: InsuranceQueries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InsuranceQuery insuranceQuery = db.InsuranceQueries.Find(id);
            db.InsuranceQueries.Remove(insuranceQuery);
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
