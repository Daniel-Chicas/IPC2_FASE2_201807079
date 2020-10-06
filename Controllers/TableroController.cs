using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Xml.Linq;

namespace WebApplication1.Controllers
{
    public class TableroController : Controller
    {
        XmlDocument doc = new XmlDocument();
        string filename = "C:\\Users\\Daniel Chicas\\Desktop\\Jugador vs Maquina.xml";

        List<string> Ficha;
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

        public string Leer(string pruta, int conteo)
        {
            conteo = conteo - 1;
            string cadena = "0&No se completó la carga";
            Ficha = new List<string>();
            if (pruta == "")
            {
                cadena = "";
                return cadena;
            }
            else
            {
                try
                {
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

                            existe = Ficha.Contains(variableAg);
                            if (existe == true || variableAg == "" || toca == "%")
                            {
                                Console.WriteLine(" ");
                            }
                            else
                            {
                                Ficha.Add(variableAg);
                            }
                            if (toca == "%" && colorToca != "")
                            {
                                Ficha.Add("Turno," + colorToca);
                                toca = "";
                            }
                        }
                    }
                    int numero = Ficha.Count();
                    if (conteo >= numero)
                    {
                        cadena = Ficha.Last();
                    }
                    else
                    {
                        cadena = Ficha[conteo];
                    }

                    return cadena;
                }
                catch (Exception ex)
                {
                    return "la ruta ingresada no es válida.";
                }
            }
        }

        public string Guardar(int contadorG, string columnaR, string filaR, string colorR)
        {
            var cadena = "";
            string cadenaS = contadorG.ToString();
            string nombreArchivo = "C:\\Users\\Daniel Chicas\\Desktop\\Jugador vs Maquina.xml";

            if (contadorG == 0 && columnaR == "k" && filaR == "9")
            {
                XmlNode turno = turnoficha(colorR);
                XmlNode ultimo = doc.DocumentElement;
                ultimo.InsertAfter(turno, ultimo.LastChild);
                doc.Save(nombreArchivo);
                cadena = "Se ha guardado el archivo.";
                return cadena;
            }

                if (System.IO.File.Exists(nombreArchivo))
            {
                XmlNode ficha = crearFicha(colorR, filaR, columnaR);
                XmlNode ultimo = doc.DocumentElement;
                ultimo.InsertAfter(ficha, ultimo.LastChild);
                doc.Save(nombreArchivo);
                cadena = "se ha guardado el archivo 2 (definitivamente ya)";
                return cadena;
            }
            else
            {
                    XmlDocument doc = new XmlDocument();
                    XmlElement raiz = doc.CreateElement("tablero");
                    doc.AppendChild(raiz);

                    XmlElement ficha = doc.CreateElement("ficha");
                    raiz.AppendChild(ficha);

                    XmlElement color = doc.CreateElement("color");
                    color.AppendChild(doc.CreateTextNode(colorR));
                    ficha.AppendChild(color);

                    XmlElement columna = doc.CreateElement("columna");
                    columna.AppendChild(doc.CreateTextNode(columnaR));
                    ficha.AppendChild(columna);

                    XmlElement fila = doc.CreateElement("fila");
                    fila.AppendChild(doc.CreateTextNode(filaR));
                    ficha.AppendChild(fila);
                    doc.Save(nombreArchivo);
                    cadena = "se ha guardado el archivo (no pero ya)";
                return cadena;
            }
            }
        
        private XmlNode crearFicha(string colorR, string filaR, string columnaR)
        {
            doc.Load("C:\\Users\\Daniel Chicas\\Desktop\\Jugador vs Maquina.xml");
            XmlNode ficha = doc.CreateElement("ficha");

            XmlElement color = doc.CreateElement("color");
            color.InnerText = colorR;
            ficha.AppendChild(color);

            XmlElement columna = doc.CreateElement("columna");
            columna.InnerText = columnaR;
            ficha.AppendChild(columna);

            XmlElement fila = doc.CreateElement("fila");
            fila.InnerText = filaR;
            ficha.AppendChild(fila);

            return ficha;
        }
        private XmlNode turnoficha(string colorR)
        {
            doc.Load("C:\\Users\\Daniel Chicas\\Desktop\\Jugador vs Maquina.xml");
            XmlNode ficha = doc.CreateElement("siguienteTiro");

            XmlElement color = doc.CreateElement("color");
            color.InnerText = colorR;
            ficha.AppendChild(color);
            return ficha;
        }
    }
}