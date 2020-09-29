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
    public class TableroController : Controller
    {
        public ActionResult Tablero()
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

        public string Conteo(string contador)
        {
            int conteo = int.Parse(contador);
            string color = "black";
            if(conteo % 2 == 0)
            {
                return color;
            }
            else
            {
                color = "white";
                return color;
            }
        }


        public string Leer(string pruta)
        {
            string cadena = "0&No se completó la carga";
            List<String> ficha = new List<string>();
            List<String> turno = new List<string>();
            XmlReader reader = XmlReader.Create(pruta);
            string color = "";
            string columna = "";
            int fila;
            var variableAgregar = "";
            string variableAg = "";
            string toca = "";
            string colorToca = "";
            Boolean existe;
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
                            color = temp.color;
                            if (toca == "%")
                            {
                                colorToca = temp.color;
                            }
                            break;
                        case "columna":
                            temp.columna = reader.ReadString();
                            columna = temp.columna;
                            break;
                        case "fila":
                            temp.fila = reader.ReadElementContentAsInt();
                            fila = temp.fila;
                            variableAgregar = color + "," + columna + "" + fila;
                            variableAg = variableAgregar.ToString();
                            break;
                        case "siguienteTiro":
                            toca = "%";
                            break;
                    }

                    existe = ficha.Contains(variableAg);
                    if (existe == true || variableAg == "" || toca == "%")
                    {
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        ficha.Add(variableAg);
                    }
                    if (toca == "%" && colorToca != "")
                    {
                        turno.Add(colorToca);
                        toca = "";
                        cadena = "1&La lista ha sido cargada";

                    }

                }
            }
            return cadena;
        }
    }

}