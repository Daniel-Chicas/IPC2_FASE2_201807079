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
    public class PartidasController : Controller
    {
        private BD_IPC2Entities db = new BD_IPC2Entities();

        // GET: Partidas
        public ActionResult Index()
        {
            return View(db.Partida.ToList());
        }

        // GET: Partidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partida.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // GET: Partidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Partidas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PuntajeId,UsuarioId,Puntaje,ColorFicha,CantidadMovimientos,EstadoPartida,TipoPartida,FechaPartida")] Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Partida.Add(partida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(partida);
        }


        [HttpPost]
        public string AnadirPuntaje(String Usuario, int Puntaje, String Color1, int Movimientos, String EstadoPartida, String TipoPartida)
        {
            Partida modeloPartida = new Partida();
            modeloPartida.UsuarioId = Usuario;
            modeloPartida.Puntaje = Puntaje;
            modeloPartida.ColorFicha = Color1;
            modeloPartida.CantidadMovimientos = Movimientos;
            modeloPartida.EstadoPartida = EstadoPartida;
            modeloPartida.TipoPartida = TipoPartida;
            modeloPartida.FechaPartida = DateTime.Now;
            db.Partida.Add(modeloPartida);
            db.SaveChanges();
            return "Partida Finalizada";
        }

        public string AnadirPuntajeCampeonato(List<string> Usuario, int Puntaje, String Color1, int Movimientos, String EstadoPartida, String TipoPartida)
        {
            for (int i = 0; i < Usuario.Count(); i++)
            {
            Partida modeloPartida = new Partida();
            modeloPartida.UsuarioId = Usuario[i];
            modeloPartida.Puntaje = Puntaje;
            modeloPartida.ColorFicha = Color1;
            modeloPartida.CantidadMovimientos = Movimientos;
            modeloPartida.EstadoPartida = EstadoPartida;
            modeloPartida.TipoPartida = TipoPartida;
            modeloPartida.FechaPartida = DateTime.Now;
            db.Partida.Add(modeloPartida);
            db.SaveChanges();
            }
            return "Partida Finalizada";
        }



        public string Puntaje(int NoBlancas, int NoNegras, String Usuario, int Puntaje, String Color1, int Movimientos, String EstadoPartida, String TipoPartida)
        {
            string cadena = "";
            if (NoBlancas == NoNegras)
            {
                cadena = "Empate";
            }
            if (NoBlancas > NoNegras)
            {
                cadena = "Perdíó";
            }
            else
            {
                cadena = "Ganó";
            }

            AnadirPuntaje(Usuario, Puntaje, Color1, Movimientos, cadena, TipoPartida);
            return cadena;
        }

        public string PuntajeApertura(int NoBlancas, int NoNegras, String Usuario, int Puntaje, String Color1, int Movimientos, String EstadoPartida, String TipoPartida)
        {
            string cadena = "";
            if (NoBlancas == NoNegras)
            {
                cadena = "Empate";
            }
            if (NoBlancas > NoNegras)
            {
                cadena = "Ganó";
            }
            else
            {
                cadena = "Perdió";
            }
            AnadirPuntaje(Usuario, Puntaje, Color1, Movimientos, cadena, TipoPartida);
            return cadena;
        }

        // GET: Partidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partida.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // POST: Partidas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PuntajeId,UsuarioId,Puntaje,ColorFicha,CantidadMovimientos,EstadoPartida,TipoPartida,FechaPartida")] Partida partida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partida);
        }

        // GET: Partidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Partida partida = db.Partida.Find(id);
            if (partida == null)
            {
                return HttpNotFound();
            }
            return View(partida);
        }

        // POST: Partidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Partida partida = db.Partida.Find(id);
            db.Partida.Remove(partida);
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
