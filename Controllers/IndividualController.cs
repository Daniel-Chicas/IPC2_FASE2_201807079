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
    public class IndividualController : Controller
    {
        XmlDocument doc = new XmlDocument();
        String path = "";
        List<string> Ficha;
        public ActionResult Individual()
        {
            Session["contar"] = 0;
            return View();
        }

        public object Usuario()
        {
            var cadena = Session["usuario"];
            return cadena;
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

        public string Conteo(int cuenta)
        {
            string cadena = "";
            if (cuenta % 2 == 0)
            {
                cadena = "white";
            }
            else
            {
                cadena = "black";
            }
            return cadena + "&" + cuenta;
        }

        public string Leer(string pruta, int conteo)
        {
            conteo = conteo - 1;
            string cadena = "0&No se completó la carga";
            Ficha = new List<string>();
            if (pruta == "")
            {
                cadena = "";
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
                    while (reader.Read() != false)
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
                    
                    int contar = 1;
                    cadena = Ficha[0];
                    while(contar != Ficha.Count())
                    {
                        cadena = cadena + "&"+Ficha[contar];
                        contar++;
                    }

                    return cadena;
                }
            catch (Exception)
            {
            cadena = "";
            return cadena;
            }
            }
            return cadena;
        }

        public string Guardar(int contadorG, string columnaR, string filaR, string colorR, string j1)
        {
            var cadena = "";
            string cadenaS = contadorG.ToString();
            path = "C:\\Users\\Daniel Chicas\\Desktop\\" + j1 + " vs Maquina.xml";
            if (contadorG == 0 && columnaR == "k" && filaR == "9")
            {
                XmlNode turno = turnoficha(colorR, j1);
                XmlNode ultimo = doc.DocumentElement;
                ultimo.InsertAfter(turno, ultimo.LastChild);
                doc.Save(path);
                cadena = "Se ha guardado el archivo.";
                return cadena;
            }
            if (System.IO.File.Exists(path))
            {
                XmlNode ficha = crearFicha(colorR, filaR, columnaR, j1);
                XmlNode ultimo = doc.DocumentElement;
                ultimo.InsertAfter(ficha, ultimo.LastChild);
                doc.Save(path);
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
                doc.Save(path);
            }
            cadena = "";
            return cadena;
        }

        public XmlNode crearFicha(string colorR, string filaR, string columnaR, string j1)
        {
            doc.Load(path);
            XmlNode fichaAg = doc.CreateElement("ficha");

            XmlElement color = doc.CreateElement("color");
            color.InnerText = colorR;
            fichaAg.AppendChild(color);

            XmlElement columna = doc.CreateElement("columna");
            columna.InnerText = columnaR;
            fichaAg.AppendChild(columna);

            XmlElement fila = doc.CreateElement("fila");
            fila.InnerText = filaR;
            fichaAg.AppendChild(fila);

            return fichaAg;
        }
        public XmlNode turnoficha(string colorR, string j1 )
        {
            try
            {
                doc.Load(path);
                XmlNode turno = doc.CreateElement("siguienteTiro");
                XmlElement color = doc.CreateElement("color");
                color.InnerText = colorR;
                turno.AppendChild(color);
                return turno;
            }
            catch (Exception ex)
            {
                doc.Load(path);
                XmlNode turno = doc.CreateElement("siguienteTiro");
                XmlElement color = doc.CreateElement("color");
                color.InnerText = colorR;
                turno.AppendChild(color);
                return turno;
            }
        }
    }
}