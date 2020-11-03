using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;
using Microsoft.Ajax.Utilities;
using System.Data;
using System.Data.Sql;

namespace WebApplication1.Controllers
{
    public class TorneoController : Controller
    {
        XmlDocument doc = new XmlDocument();
        List<string> Ficha;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Torneo()
        {
            Session["lectura"] = "";
            Session["Campeonato"] = "";
            return View();
        }

        public string Datos(List<List<string>> jugadores)
        {
            Session["lectura"] = jugadores;
            string cadena = "";
            if(jugadores.Count() != 0)
            {
                cadena = "Bienvenido al juego";
            }
            else
            {
                cadena = "No se ha podido cargar el campeonato, intente nuevamente.";
            }
            return cadena;
        }




        public string NombreTorneo(string nombre, int cantidad)
        {
            string cadena = "El campeonato \""+nombre+"\" ha sido creado.";
            Session["Campeonato"] = nombre;
            Session["cantidadIntegrantes"] = cantidad;
            return cadena;
        }

        public ActionResult Jugadores()
        {
            if(Session["cantidadIntegrantes"].ToString() == "")
            {
                Session["cantidadIntegrantes"] = 4;
            };
            return View();
        }

        public string DatosJugadores()
        {
            string cadena = "";
            List<List<string>> datos = (List<List<string>>)Session["lectura"];
            int contador = 0;
            while(contador != datos.Count())
            {
                int contint = 0;
                List<string> actual = datos[contador];
                while (contint < 4)
                {
                    cadena = cadena + actual[contint]+"&";
                    contint++;
                }
                cadena = cadena + ";";
                contador++;
            }



            return cadena;
        }



        public ActionResult Diseño4()
        {
            return View();
        }

        public ActionResult Diseño8()
        {
            return View();
        }

        public ActionResult Diseño16()
        {
            return View();
        }


        public string Integrantes()
        {
            string cadena = Session["cantidadIntegrantes"].ToString();
            return cadena;
        }

        public ActionResult TableroCampeonato()
        {
            Session["turnosEquipos"]=0;
            Session["contar"] = 0;
            return View();
        }

        public string Turnos()
        {
            int contador = (int)Session["turnosEquipos"];
            List<List<string>> equipos = (List<List<string>>)Session["lectura"];
            List<string> jugador1 = equipos[contador];
            List<string> jugador2 = equipos[contador+1];
            string cadena = jugador1[0] + "&" + jugador2[0];
            return cadena;
        }



        public string Conteo()
        {
            string cadena;
            int cuenta = (int)Session["contar"];
            cuenta++;
            if (cuenta % 2 == 0)
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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
                    Torneo temp = new Torneo();
                    XmlReader reader = XmlReader.Create(pruta);
                    List<List<string>> datos = new List<List<string>> { };
                    List<string> info = new List<string> { };
                    string NombreCampeonato = "";
                    int contador = 0;
                    string jugador = "";
                    string nombreEquipo = "";
                    while (reader.Read() != false)
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name.ToString())
                            {
                                case "campeonato":
                                    break;
                                case "nombre":
                                    temp.nombreCampeonato = reader.ReadString();
                                    NombreCampeonato = temp.nombreCampeonato;
                                    Session["Campeonato"] = NombreCampeonato;
                                    break;
                                case "equipo":
                                    contador++;
                                    if (info.Count() != 0)
                                    {
                                        List<string> ingresa = (List<string>)info;
                                        datos.Add(ingresa);
                                        info = new List<string>{ };
                                    }
                                    break;
                                case "nombreEquipo":
                                    if(contador == 1)
                                    {
                                        temp.nombreEquipo1 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo1;
                                    }
                                    if (contador == 2)
                                    {
                                        temp.nombreEquipo2 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo2;
                                    }
                                    if (contador == 3)
                                    {
                                        temp.nombreEquipo3 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo3;
                                    }
                                    if (contador == 4)
                                    {
                                        temp.nombreEquipo4 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo4;
                                    }
                                    if (contador == 5)
                                    {
                                        temp.nombreEquipo5 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo5;
                                    }
                                    if (contador == 6)
                                    {
                                        temp.nombreEquipo6 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo6;
                                    }
                                    if (contador == 7)
                                    {
                                        temp.nombreEquipo7 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo7;
                                    }
                                    if (contador == 8)
                                    {
                                        temp.nombreEquipo8 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo8;
                                    }
                                    if (contador == 9)
                                    {
                                        temp.nombreEquipo9 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo9;
                                    }
                                    if (contador == 10)
                                    {
                                        temp.nombreEquipo10 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo10;
                                    }
                                    if (contador == 11)
                                    {
                                        temp.nombreEquipo11 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo11;
                                    }
                                    if (contador == 12)
                                    {
                                        temp.nombreEquipo12 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo12;
                                    }
                                    if (contador == 13)
                                    {
                                        temp.nombreEquipo13 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo13;
                                    }
                                    if (contador == 14)
                                    {
                                        temp.nombreEquipo14 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo14;
                                    }
                                    if (contador == 15)
                                    {
                                        temp.nombreEquipo15 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo15;
                                    }
                                    if (contador == 16)
                                    {
                                        temp.nombreEquipo16 = reader.ReadString();
                                        nombreEquipo = temp.nombreEquipo16;
                                    }
                                    info.Add(nombreEquipo);
                                    break;
                                case "jugador":
                                    temp.jugadores1 = reader.ReadString();
                                    jugador = temp.jugadores1;
                                    info.Add(jugador);
                                    break;
                            }
                        }
                    }
                    datos.Add(info);
                    cadena = "La archivo fue cargado con éxito.";

                    Session["lectura"] = datos;
                    Session["cantidadIntegrantes"] = datos.Count();

                }
                catch (Exception)
                {
                    cadena = "El archivo no pudo ser cargado.";
                    return cadena;
                }
            }
            return cadena;
        }

        public object usuario()
        {
            var cadena = Session["usuario"];
            return cadena;
        }
    }
}