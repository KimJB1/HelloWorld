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
    public class tbl_DistrictsController : Controller
    {
        private RealEstateEntities db = new RealEstateEntities();

        // GET: Admin/tbl_Districts
        public ActionResult Index()
        {
            var tbl_District = db.tbl_District.Include(t => t.tbl_City);
            return View(tbl_District.ToList());
        }

        // GET: Admin/tbl_Districts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_District tbl_District = db.tbl_District.Find(id);
            if (tbl_District == null)
            {
                return HttpNotFound();
            }
            return View(tbl_District);
        }

        // GET: Admin/tbl_Districts/Create
        public ActionResult Create()
        {
            ViewBag.ID_City = new SelectList(db.tbl_City, "ID_City", "City_Name");
            return View();
        }

        // POST: Admin/tbl_Districts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_District,District_Name,ID_City,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_District tbl_District)
        {
            if (ModelState.IsValid)
            {
                tbl_District.CreateDate = DateTime.Now;
                db.tbl_District.Add(tbl_District);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_City = new SelectList(db.tbl_City, "ID_City", "City_Name", tbl_District.ID_City);
            return View(tbl_District);
        }

        // GET: Admin/tbl_Districts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_District tbl_District = db.tbl_District.Find(id);
            if (tbl_District == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_City = new SelectList(db.tbl_City, "ID_City", "City_Name", tbl_District.ID_City);
            return View(tbl_District);
        }

        // POST: Admin/tbl_Districts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_District,District_Name,ID_City,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_District tbl_District)
        {
            if (ModelState.IsValid)
            {
                tbl_District.UpdateDate = DateTime.Now;
                db.Entry(tbl_District).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_City = new SelectList(db.tbl_City, "ID_City", "City_Name", tbl_District.ID_City);
            return View(tbl_District);
        }

        // GET: Admin/tbl_Districts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_District tbl_District = db.tbl_District.Find(id);
            if (tbl_District == null)
            {
                return HttpNotFound();
            }
            return View(tbl_District);
        }

        // POST: Admin/tbl_Districts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_District tbl_District = db.tbl_District.Find(id);
            db.tbl_District.Remove(tbl_District);
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

        public ActionResult DeleteQH(int id)
        {
            tbl_District tbl_District = db.tbl_District.Find(id);
            db.tbl_District.Remove(tbl_District);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
