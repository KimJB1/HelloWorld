using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BatDongSan.Models;

namespace BatDongSan.Areas.Admin.Controllers
{
    public class tbl_CitysController : Controller
    {
        private RealEstateEntities db = new RealEstateEntities();

        // GET: Admin/tbl_Citys
        public ActionResult Index()
        {
            return View(db.tbl_City.ToList());
        }

        // GET: Admin/tbl_Citys/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_City tbl_City = db.tbl_City.Find(id);
            if (tbl_City == null)
            {
                return HttpNotFound();
            }
            return View(tbl_City);
        }

        // GET: Admin/tbl_Citys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tbl_Citys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_City,City_Name,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_City tbl_City)
        {
            if (ModelState.IsValid)
            {
                tbl_City.CreateDate = DateTime.Now;
                db.tbl_City.Add(tbl_City);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_City);
        }

        // GET: Admin/tbl_Citys/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_City tbl_City = db.tbl_City.Find(id);
            if (tbl_City == null)
            {
                return HttpNotFound();
            }
            return View(tbl_City);
        }

        // POST: Admin/tbl_Citys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_City,City_Name,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_City tbl_City)
        {
            if (ModelState.IsValid)
            {
                tbl_City.UpdateDate = DateTime.Now;
                db.Entry(tbl_City).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_City);
        }

        // GET: Admin/tbl_Citys/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_City tbl_City = db.tbl_City.Find(id);
            if (tbl_City == null)
            {
                return HttpNotFound();
            }
            return View(tbl_City);
        }

        // POST: Admin/tbl_Citys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_City tbl_City = db.tbl_City.Find(id);
            db.tbl_City.Remove(tbl_City);
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

        public ActionResult DeleteTT(int id)
        {
            tbl_City tbl_City = db.tbl_City.Find(id);
            db.tbl_City.Remove(tbl_City);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
