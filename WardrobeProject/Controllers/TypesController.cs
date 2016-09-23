using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardrobeProject.Models;

namespace WardrobeProject.Controllers
{
    public class TypesController : Controller
    {
        private WardrobeProjectContext db = new WardrobeProjectContext();

        // GET: Types
        public ActionResult Index()
        {
            var types = db.Types.Include(t => t.Accessory).Include(t => t.Bottom).Include(t => t.Shoe).Include(t => t.Top);
            return View(types.ToList());
        }

        // GET: Types/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type type = db.Types.Find(id);
            if (type == null)
            {
                return HttpNotFound();
            }
            return View(type);
        }

        // GET: Types/Create
        public ActionResult Create()
        {
            ViewBag.accessoryID = new SelectList(db.Accessories, "accessoryID", "accessoryItemName");
            ViewBag.bottomID = new SelectList(db.Bottoms, "bottomID", "bottomItemName");
            ViewBag.shoeID = new SelectList(db.Shoes, "shoeID", "shoeItemName");
            ViewBag.topID = new SelectList(db.Tops, "topID", "topItemName");
            return View();
        }

        // POST: Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "typeID,typeItemName,photo,topID,bottomID,shoeID,accessoryID")] Type type)
        {
            if (ModelState.IsValid)
            {
                db.Types.Add(type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.accessoryID = new SelectList(db.Accessories, "accessoryID", "accessoryItemName", type.accessoryID);
            ViewBag.bottomID = new SelectList(db.Bottoms, "bottomID", "bottomItemName", type.bottomID);
            ViewBag.shoeID = new SelectList(db.Shoes, "shoeID", "shoeItemName", type.shoeID);
            ViewBag.topID = new SelectList(db.Tops, "topID", "topItemName", type.topID);
            return View(type);
        }

        // GET: Types/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type type = db.Types.Find(id);
            if (type == null)
            {
                return HttpNotFound();
            }
            ViewBag.accessoryID = new SelectList(db.Accessories, "accessoryID", "accessoryItemName", type.accessoryID);
            ViewBag.bottomID = new SelectList(db.Bottoms, "bottomID", "bottomItemName", type.bottomID);
            ViewBag.shoeID = new SelectList(db.Shoes, "shoeID", "shoeItemName", type.shoeID);
            ViewBag.topID = new SelectList(db.Tops, "topID", "topItemName", type.topID);
            return View(type);
        }

        // POST: Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "typeID,typeItemName,photo,topID,bottomID,shoeID,accessoryID")] Type type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.accessoryID = new SelectList(db.Accessories, "accessoryID", "accessoryItemName", type.accessoryID);
            ViewBag.bottomID = new SelectList(db.Bottoms, "bottomID", "bottomItemName", type.bottomID);
            ViewBag.shoeID = new SelectList(db.Shoes, "shoeID", "shoeItemName", type.shoeID);
            ViewBag.topID = new SelectList(db.Tops, "topID", "topItemName", type.topID);
            return View(type);
        }

        // GET: Types/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Type type = db.Types.Find(id);
            if (type == null)
            {
                return HttpNotFound();
            }
            return View(type);
        }

        // POST: Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Type type = db.Types.Find(id);
            db.Types.Remove(type);
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
