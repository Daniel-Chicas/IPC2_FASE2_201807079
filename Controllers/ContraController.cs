﻿using System;
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
    public class ContraController : Controller
    {
        XmlDocument doc = new XmlDocument();
        List<string> Ficha;
        public ActionResult Contra()
        {
            Session["contar"] = 0;
            return View();
        }

        public object Usuario()
        {
            var cadena = Session["usuario"];
            return cadena;
        }

        public string Conteo()
        {
            string cadena = "";
            int cuenta = (int)Session["contar"];
            cuenta = cuenta + 1;
            if(cuenta % 2 == 0)
            {
                cadena = "white";
            }
            else
            {
                cadena = "black";
            }
            Session["contar"] = cuenta;
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
                    while (contar != Ficha.Count())
                    {
                        cadena = cadena + "&" + Ficha[contar];
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

        public string Guardar(int contadorG, string columnaR, string filaR, string colorR, string j1, string j2)
        {
            var cadena = "";
            string cadenaS = contadorG.ToString();
            string nombreArchivo = "C:\\Users\\Daniel Chicas\\Desktop\\"+j1+" vs "+j2+".xml";



            if (contadorG == 0 && columnaR == "k" && filaR == "9")
            {
                    XmlNode turno = turnoficha(colorR, j1, j2);
                    XmlNode ultimo = doc.DocumentElement;
                    ultimo.InsertAfter(turno, ultimo.LastChild);
                    doc.Save(nombreArchivo);
                    cadena = "Se ha guardado el archivo.";
                    return cadena;
            }
            if (System.IO.File.Exists(nombreArchivo))
            {
                XmlNode ficha = crearFicha(colorR, filaR, columnaR, j1, j2);
                XmlNode ultimo = doc.DocumentElement;
                ultimo.InsertAfter(ficha, ultimo.LastChild);
                doc.Save(nombreArchivo);
                cadena = "";
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
                cadena = "";
                return cadena;
            }
        }

        private XmlNode crearFicha(string colorR, string filaR, string columnaR, string j1, string j2)
        {
            doc.Load("C:\\Users\\Daniel Chicas\\Desktop\\" + j1 + " vs Maquina.xml");
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
        private XmlNode turnoficha(string colorR, string j1, string j2)
        {
            try
            {
                doc.Load("C:\\Users\\Daniel Chicas\\Desktop\\" + j1 + " vs Maquina.xml");
                XmlNode turno = doc.CreateElement("siguienteTiro");
                XmlElement color = doc.CreateElement("color");
                color.InnerText = colorR;
                turno.AppendChild(color);
                return turno;
            }
            catch (Exception ex)
            {
                XmlNode ficha = doc.CreateElement("siguienteTiro");
                XmlElement color = doc.CreateElement("color");
                color.InnerText = colorR;
                ficha.AppendChild(color);
                return ficha;
            }
            }
    }
}