using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;
using System.Data;
using System.Data.Sql;

namespace WebApplication1.Controllers
{
    public class CargarController : Controller
    {
        public ActionResult Cargar()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Leer(string pruta)
        {
            var ArrayFichas = new List<Ficha>();
            XmlReader reader = XmlReader.Create(pruta);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    Ficha temp = new Ficha();
                    switch (reader.Name.ToString())
                    {
                        case "tablero":
                            break;
                        case "ficha":
                            break;
                        case "color":
                            temp.color = reader.ReadString();
                            break;
                        case "columna":
                            temp.columna = reader.ReadString();
                            break;
                        case "fila":
                            temp.fila = reader.ReadElementContentAsInt();
                            break;
                        case "siguientetiro":
                            break;
                    }
                }
                
            }
            return View();
        }
    }
}