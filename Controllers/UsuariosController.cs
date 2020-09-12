using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class UsuariosController : Controller
    {
        private BD_Entity db = new BD_Entity();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Usuario.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Usuarioid,Nombre,Apellidos,Usuario1,Contraseña,FechaNacimiento,Correo,Pais,EstadoId,FechaUltMod")] Usuario usuario)
        {
            string validador = ValidarUsuarioRepetido(usuario.Usuario1);

            if (validador == "0")
            {
                usuario.EstadoId = 1;
                usuario.FechaUltMod = DateTime.Now;
                if (ModelState.IsValid)
                {
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                    return RedirectToAction("Principal");
                }

                return View(usuario);
            }
            else
            {
                ViewBag.TextoUsuarioRepetido = "Usuario repetido. Intente con otro alias.";
                return View(usuario);
            }
               

        }

        public RedirectToRouteResult Principal()
        {
            return RedirectToAction("Index", "Home");
        }

        // GET: Usuarios/Edit/5


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Usuarioid,Nombre,Apellidos,Usuario1,Contraseña,FechaNacimiento,Correo,Pais,EstadoId,FechaUltMod")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
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

        

        public string ValidarUsuario(string pusuario, string pcontrasena)
        {
            Usuario usuario = db.Usuario.Where(s => s.Usuario1 == pusuario && s.Contraseña == pcontrasena).FirstOrDefault();

            if (usuario != null)
            {
                //return RedirectToAction("Index", "Usuarios");
                
                if (usuario.EstadoId == 1)
                {
                    return "1&OK";
                }
                else
                {
                    return "2&Usuario inactivo";
                }
            }
            else
            {
                return "2&Usuario o contraseña incorrecta. Revise los datos";
            }
        }

        //public string validarTorneo(string pTorneo)
        //{
        //    Usuario usuario = db.Usuario.Where(s => s.Usuario1 == pusuario).FirstOrDefault();

        //    if (usuario != null)
        //    {
        //        //return RedirectToAction("Index", "Usuarios");

        //        if (usuario.EstadoId == 1)
        //        {
        //            return "1&OK";
        //        }
        //        else
        //        {
        //            return "2&Usuario inactivo";
        //        }
        //    }
        //    else
        //    {
        //        return "2&Usuario inválido";
        //    }
        //}

        public string EditarEstado(string pusuario, int pestado)
        {
            Usuario usuario = db.Usuario.Where(s => s.Usuario1 == pusuario).FirstOrDefault();
            if (usuario == null)
            {
                return "0";
            }
            else
            {
                usuario.EstadoId = pestado;
                
                db.SaveChanges();
                return "1";
            }
        }


        public string ValidarUsuarioRepetido(string pusuario)
        {
            Usuario usuario = db.Usuario.Where(s => s.Usuario1 == pusuario && s.EstadoId==1).FirstOrDefault();

            if (usuario == null)
            {
                //return RedirectToAction("Index", "Usuarios");
                return "0";
            }
            else
            {
                return "1";
            }
        }

        public ActionResult Deshabilitar()
        {
            return View();
        }
    }
}
