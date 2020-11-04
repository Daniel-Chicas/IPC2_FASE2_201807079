using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    public class CampeonatoesController : Controller
    {
        private BD_IPC2Entities db = new BD_IPC2Entities();

        // GET: Campeonatoes
        public ActionResult Index()
        {
            return View(db.Campeonato.ToList());
        }

        // GET: Campeonatoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campeonato campeonato = db.Campeonato.Find(id);
            if (campeonato == null)
            {
                return HttpNotFound();
            }
            return View(campeonato);
        }

        // GET: Campeonatoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Campeonatoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTorneo,UsuarioIdCreador,NombreTorneo,CantidadEquipos,EquipoGanador,FechaCreacion,Estado")] Campeonato campeonato)
        {
            if (ModelState.IsValid)
            {
                db.Campeonato.Add(campeonato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(campeonato);
        }

        public string AnadirCampeonato(String usuario, string nombre, string cantidadEquipos, string estado, string ganador)
        {
            Campeonato modeloCampeonato = new Campeonato();
            modeloCampeonato.UsuarioIdCreador = usuario;
            modeloCampeonato.NombreTorneo = nombre;
            modeloCampeonato.CantidadEquipos = cantidadEquipos;
            modeloCampeonato.EquipoGanador = ganador;
            modeloCampeonato.FechaCreacion = DateTime.Now;
            modeloCampeonato.Estado = estado;
            db.Campeonato.Add(modeloCampeonato);
            db.SaveChanges();
            return "Partida Finalizada";
        }



        // GET: Campeonatoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campeonato campeonato = db.Campeonato.Find(id);
            if (campeonato == null)
            {
                return HttpNotFound();
            }
            return View(campeonato);
        }

        // POST: Campeonatoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTorneo,UsuarioIdCreador,NombreTorneo,CantidadEquipos,EquipoGanador,FechaCreacion,Estado")] Campeonato campeonato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campeonato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(campeonato);
        }

        // GET: Campeonatoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campeonato campeonato = db.Campeonato.Find(id);
            if (campeonato == null)
            {
                return HttpNotFound();
            }
            return View(campeonato);
        }

        // POST: Campeonatoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Campeonato campeonato = db.Campeonato.Find(id);
            db.Campeonato.Remove(campeonato);
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
