using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFilmoteka.Models;

namespace MvcFilmoteka.Controllers
{ 
    public class AktorController : Controller
    {
        private FilmEntities db = new FilmEntities();

        //
        // GET: /Aktor/

        public ViewResult Index()
        {
            return View(db.Aktors.ToList());
        }

        //
        // GET: /Aktor/Details/5

        public ViewResult Details(int id)
        {
            Aktor aktor = db.Aktors.Single(a => a.id == id);
            return View(aktor);
        }

        //
        // GET: /Aktor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Aktor/Create

        [HttpPost]
        public ActionResult Create(Aktor aktor)
        {
            if (ModelState.IsValid)
            {
                db.Aktors.AddObject(aktor);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(aktor);
        }
        
        //
        // GET: /Aktor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Aktor aktor = db.Aktors.Single(a => a.id == id);
            return View(aktor);
        }

        //
        // POST: /Aktor/Edit/5

        [HttpPost]
        public ActionResult Edit(Aktor aktor)
        {
            if (ModelState.IsValid)
            {
                db.Aktors.Attach(aktor);
                db.ObjectStateManager.ChangeObjectState(aktor, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aktor);
        }

        //
        // GET: /Aktor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Aktor aktor = db.Aktors.Single(a => a.id == id);
            return View(aktor);
        }

        //
        // POST: /Aktor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Aktor aktor = db.Aktors.Single(a => a.id == id);
            db.Aktors.DeleteObject(aktor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}