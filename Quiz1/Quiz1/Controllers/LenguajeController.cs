using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataQuiz;
using DataQuiz.Models;

namespace Quiz1.Controllers
{
    public class LenguajeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Lenguaje
        public ActionResult Index()
        {
            var lenguajesProyecto = new LenguajesProyecto();
            lenguajesProyecto.lenguaje = db.Lenguajes.ToList();
            return View(lenguajesProyecto);
      
        }

        // GET: Lenguaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lenguaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] Lenguaje lenguaje)
        {
            if (ModelState.IsValid)
            {
                db.Lenguajes.Add(lenguaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lenguaje);
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
