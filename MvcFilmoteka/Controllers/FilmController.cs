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
    public class FilmController : Controller
    {
        private FilmEntities db = new FilmEntities();

        //
        // GET: /Film/

        public ViewResult Index()
        {
            return View(db.Films.ToList());
        }

        //
        // GET: /Film/Details/5

        public ViewResult Details(int id)
        {
            Film film = db.Films.Single(f => f.id == id);
            return View(film);
        }

        //
        // GET: /Film/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Film/Create

        [HttpPost]
        public ActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.AddObject(film);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(film);
        }
        
        //
        // GET: /Film/Edit/5
 
        public ActionResult Edit(int id)
        {
            Film film = db.Films.Single(f => f.id == id);
            return View(film);
        }

        //
        // POST: /Film/Edit/5

        [HttpPost]
        public ActionResult Edit(Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Attach(film);
                db.ObjectStateManager.ChangeObjectState(film, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        //
        // GET: /Film/Delete/5
 
        public ActionResult Delete(int id)
        {
            Film film = db.Films.Single(f => f.id == id);
            return View(film);
        }

        //
        // POST: /Film/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Film film = db.Films.Single(f => f.id == id);
            db.Films.DeleteObject(film);
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