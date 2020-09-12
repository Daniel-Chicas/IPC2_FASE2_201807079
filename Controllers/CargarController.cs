using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;

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

        //public ActionResult Leer(string pruta)
        //{
        //    var ArrayFichas = new List<Ficha>();
        //    XmlTextReader lector = new XmlTextReader(pruta);
        //    while (lector.Read())
        //    {
        //        if (lector.IsStartElement())
        //        {
        //            Ficha temp = new Ficha();
        //            switch (lector.Name.ToString())
        //            {
        //                case "color":
        //                    //color.Append(lector.ReadString());
        //                    temp.color = lector.ReadString();
        //                    break;
        //                case "columna":
        //                    //tx1.AppendText("color de la fruta: " + lector.ReadString() + "\r\n");
        //                    temp.columna = lector.ReadString();
        //                    break;
        //                case "fila":
        //                    //tx1.AppendText("tamanio de la fruta: " + lector.ReadString() + "\r\n\r\n");
        //                    temp.fila = int.Parse(lector.ReadString());
        //                    break;
        //            }
        //            ArrayFichas.Add(temp);
        //        }

        //        foreach (var item in ArrayFichas)
        //        {
        //            Console.WriteLine(item.columna+"-"+item.fila+"-"+item.color);

        //        }
                
        //    }
        //    return View();
        //}
    }
}