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
    public class tbl_WardsController : Controller
    {
        private RealEstateEntities db = new RealEstateEntities();

        // GET: Admin/tbl_Wards
        public ActionResult Index()
        {
            var tbl_Ward = db.tbl_Ward.Include(t => t.tbl_District);
            return View(tbl_Ward.ToList());
        }

        // GET: Admin/tbl_Wards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Ward tbl_Ward = db.tbl_Ward.Find(id);
            if (tbl_Ward == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Ward);
        }

        // GET: Admin/tbl_Wards/Create
        public ActionResult Create()
        {
            ViewBag.ID_District = new SelectList(db.tbl_District, "ID_District", "District_Name");
            return View();
        }

        // POST: Admin/tbl_Wards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Ward,Ward_Name,ID_District,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_Ward tbl_Ward)
        {
            if (ModelState.IsValid)
            {
                tbl_Ward.CreateDate = DateTime.Now;
                db.tbl_Ward.Add(tbl_Ward);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_District = new SelectList(db.tbl_District, "ID_District", "District_Name", tbl_Ward.ID_District);
            return View(tbl_Ward);
        }

        // GET: Admin/tbl_Wards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Ward tbl_Ward = db.tbl_Ward.Find(id);
            if (tbl_Ward == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_District = new SelectList(db.tbl_District, "ID_District", "District_Name", tbl_Ward.ID_District);
            return View(tbl_Ward);
        }

        // POST: Admin/tbl_Wards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Ward,Ward_Name,ID_District,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_Ward tbl_Ward)
        {
            if (ModelState.IsValid)
            {
                tbl_Ward.UpdateDate = DateTime.Now;
                db.Entry(tbl_Ward).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_District = new SelectList(db.tbl_District, "ID_District", "District_Name", tbl_Ward.ID_District);
            return View(tbl_Ward);
        }

        // GET: Admin/tbl_Wards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Ward tbl_Ward = db.tbl_Ward.Find(id);
            if (tbl_Ward == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Ward);
        }

        // POST: Admin/tbl_Wards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Ward tbl_Ward = db.tbl_Ward.Find(id);
            db.tbl_Ward.Remove(tbl_Ward);
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

        public ActionResult DeleteXP(int id)
        {
            tbl_Ward tbl_Ward = db.tbl_Ward.Find(id);
            db.tbl_Ward.Remove(tbl_Ward);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
