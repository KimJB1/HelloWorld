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
    public class tbl_AccountsController : Controller
    {
        private RealEstateEntities db = new RealEstateEntities();

        // GET: Admin/tbl_Accounts
        public ActionResult Index()
        {
            var tbl_Account = db.tbl_Account.Include(t => t.tbl_Position);
            return View(tbl_Account.ToList());
        }

        // GET: Admin/tbl_Accounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Account tbl_Account = db.tbl_Account.Find(id);
            if (tbl_Account == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Account);
        }

        // GET: Admin/tbl_Accounts/Create
        public ActionResult Create()
        {
            ViewBag.ID_Position = new SelectList(db.tbl_Position, "ID_Position", "Position_Name");
            return View();
        }

        // POST: Admin/tbl_Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Account,Account_Name,Sex,Birthday,Address,Email,Phone,ID_Position,Account,Pass,CreateBy,UpdateBy,CreateDate,UpdateDate,Status,Avarta")] tbl_Account tbl_Account)
        {
            if (ModelState.IsValid)
            {
                tbl_Account.CreateDate = DateTime.Now;
                db.tbl_Account.Add(tbl_Account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Position = new SelectList(db.tbl_Position, "ID_Position", "Position_Name", tbl_Account.ID_Position);
            return View(tbl_Account);
        }

        // GET: Admin/tbl_Accounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Account tbl_Account = db.tbl_Account.Find(id);
            if (tbl_Account == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Position = new SelectList(db.tbl_Position, "ID_Position", "Position_Name", tbl_Account.ID_Position);
            return View(tbl_Account);
        }

        // POST: Admin/tbl_Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Account,Account_Name,Sex,Birthday,Address,Email,Phone,ID_Position,Account,Pass,CreateBy,UpdateBy,CreateDate,UpdateDate,Status,Avarta")] tbl_Account tbl_Account)
        {
            if (ModelState.IsValid)
            {
                tbl_Account.UpdateDate = DateTime.Now;
                db.Entry(tbl_Account).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Position = new SelectList(db.tbl_Position, "ID_Position", "Position_Name", tbl_Account.ID_Position);
            return View(tbl_Account);
        }

        // GET: Admin/tbl_Accounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Account tbl_Account = db.tbl_Account.Find(id);
            if (tbl_Account == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Account);
        }

        // POST: Admin/tbl_Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Account tbl_Account = db.tbl_Account.Find(id);
            db.tbl_Account.Remove(tbl_Account);
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

        public ActionResult Deletee(int id)
        {
            tbl_Account tbl_Account = db.tbl_Account.Find(id);
            db.tbl_Account.Remove(tbl_Account);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
