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
    public class tbl_PositionsController : Controller
    {
        private RealEstateEntities db = new RealEstateEntities();

        // GET: Admin/tbl_Positions
        public ActionResult Index()
        {
            return View(db.tbl_Position.ToList());
        }

        // GET: Admin/tbl_Positions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Position tbl_Position = db.tbl_Position.Find(id);
            if (tbl_Position == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Position);
        }

        // GET: Admin/tbl_Positions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tbl_Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Position,Position_Name,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_Position tbl_Position)
        {
            if (ModelState.IsValid)
            {
                tbl_Position.CreateDate = DateTime.Now;
                db.tbl_Position.Add(tbl_Position);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Position);
        }

        // GET: Admin/tbl_Positions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Position tbl_Position = db.tbl_Position.Find(id);
            if (tbl_Position == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Position);
        }

        // POST: Admin/tbl_Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Position,Position_Name,CreateBy,UpdateBy,CreateDate,UpdateDate,Status")] tbl_Position tbl_Position)
        {
            if (ModelState.IsValid)
            {
                tbl_Position.UpdateDate = DateTime.Now;
                db.Entry(tbl_Position).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Position);
        }

        // GET: Admin/tbl_Positions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Position tbl_Position = db.tbl_Position.Find(id);
            if (tbl_Position == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Position);
        }

        // POST: Admin/tbl_Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Position tbl_Position = db.tbl_Position.Find(id);
            db.tbl_Position.Remove(tbl_Position);
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

        public ActionResult DeleteCV(int id)
        {
            tbl_Position tbl_Position = db.tbl_Position.Find(id);
            db.tbl_Position.Remove(tbl_Position);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
