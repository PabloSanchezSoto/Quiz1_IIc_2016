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
    public class ProyectoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Proyecto
        public ActionResult Index()
        {
            var lenguajesProyecto = new LenguajesProyecto();
            lenguajesProyecto.proyecto = db.Proyectos.ToList();    
            return View(lenguajesProyecto);
        }
        // GET: Proyecto/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Proyecto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Puesto,NombreEmpreza,fecha,descripcion")] Proyecto proyecto)
        {
            if (ModelState.IsValid)
            {
                db.Proyectos.Add(proyecto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proyecto);
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
