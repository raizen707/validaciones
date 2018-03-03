using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ValidacionesUDEO.Models;

namespace ValidacionesUDEO.Controllers
{
    public class validaciones1Controller : Controller
    {
        private validacionesEntities db = new validacionesEntities();

        // GET: validaciones1
        public ActionResult Index()
        {
            ViewData["Message"] = "Mensaje desde el servidor!";
            ViewBag.Name = "Steveen Blanco VIEW BAG";
            TempData["ModelName"] = "Mensaje Temporal";

            return View(db.validaciones1.ToList());
        }

        // GET: validaciones1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            validaciones1 validaciones1 = db.validaciones1.Find(id);
            if (validaciones1 == null)
            {
                return HttpNotFound();
            }
            return View(validaciones1);
        }

        // GET: validaciones1/Create
        public ActionResult Create()
        {
            return View();
        }


        public JsonResult IsUserInDB(string usuario)
        {
          return Json(!db.validaciones1.Any(user => user.usuario == usuario), JsonRequestBehavior.AllowGet);
        }


        // POST: validaciones1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "usuario,password,password2,email,email2,edad,edad2,fecha,fecha2,textoPequenio,textMediano,textoGrande,tarjetaDeCredito")] validaciones1 validaciones1)
        {
            if (ModelState.IsValid)
            {
                db.validaciones1.Add(validaciones1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(validaciones1);
        }

        // GET: validaciones1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            validaciones1 validaciones1 = db.validaciones1.Find(id);
            if (validaciones1 == null)
            {
                return HttpNotFound();
            }
            return View(validaciones1);
        }

        // POST: validaciones1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "usuario,password,password2,email,email2,edad,edad2,fecha,fecha2,textoPequenio,textMediano,textoGrande,tarjetaDeCredito")] validaciones1 validaciones1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(validaciones1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(validaciones1);
        }

        // GET: validaciones1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            validaciones1 validaciones1 = db.validaciones1.Find(id);
            if (validaciones1 == null)
            {
                return HttpNotFound();
            }
            return View(validaciones1);
        }

        // POST: validaciones1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            validaciones1 validaciones1 = db.validaciones1.Find(id);
            db.validaciones1.Remove(validaciones1);
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
