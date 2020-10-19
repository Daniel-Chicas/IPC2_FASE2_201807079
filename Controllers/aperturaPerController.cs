using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class aperturaPerController : Controller
    {
        public ActionResult Index()
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

        public string Color(List<string> color1, List<string> color2)
        {
            Session["contadorJ1"] = 0;
            Session["contadorJ2"] = 0;
            Session["contadorG"] = 0;
            Session["jugador1"] = color1;
            Session["jugador2"] = color2;
            return " ";
        }

        public string Punteo(List<string> coloresFichas)
        {
            List<String> colorJugador1 = (List<String>)Session["jugador1"];
            List<String> colorJugador2 = (List<String>)Session["jugador2"];
            List<String> fichasJ1 = new List<string> { };
            List<String> fichasJ2 = new List<string> { };
            fichasJ1.Clear();
            fichasJ2.Clear();
            for (int i = 0; i < colorJugador1.Count(); i++)
            {
                for (int j = 0; j < coloresFichas.Count(); j++)
                {
                    String ficha = coloresFichas[j];
                    String ficha1 = colorJugador1[i];
                    if(ficha1 == ficha)
                    {
                        fichasJ1.Add(ficha);
                    }
                }
            }
            for(int i = 0; i < colorJugador2.Count(); i++)
            {
                for (int j = 0; j < coloresFichas.Count(); j++)
                {
                    String ficha = coloresFichas[j];
                    String ficha1 = colorJugador2[i];
                    if (ficha1 == ficha)
                    {
                        fichasJ2.Add(ficha);
                    }
                }
            }
            string cadena1 = fichasJ1.Count().ToString();
            string cadena2 = fichasJ2.Count().ToString();

            return cadena1+"&"+cadena2;
        }

        public string ColoresUsuario()
        {
            List<String> colorJugador1 = (List<String>)Session["jugador1"];
            List<String> colorJugador2 = (List<String>)Session["jugador2"];
            int contador1 = (int)Session["contadorJ1"];
            int contador2 = (int)Session["contadorJ2"];
            int contadorG = (int)Session["contadorG"];
            var cadena = "";
            if(contadorG % 2 == 0){
                if(contador1 == colorJugador1.Count){
                    contador1 = 0;
                }
                cadena = colorJugador1[contador1];
                contador1 = contador1 + 1;
            }
            else{
                if (contador2 == colorJugador2.Count){
                    contador2 = 0;
                }
                cadena = colorJugador2[contador2];
                contador2 = contador2 + 1;
            }
            contadorG = contadorG + 1;
            Session["contadorG"] = contadorG;
            Session["contadorJ1"] = contador1;
            Session["contadorJ2"] = contador2;
            return cadena+"&"+contadorG;
        }


        public string Conteo(int contador)
        {
            string color = "black";
            if (contador % 2 == 0)
            {
                return color;
            }
            else
            {
                color = "white";
                return color;
            }
        }
    }
}