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

        public string datosTorneo(int tipo)
        {
            string cadena = "";
            if(tipo == 1)
            {
                cadena = Session["Campeonato"].ToString();
            }
            return cadena;
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

        public string PunteoDS(List<string> ganadores)
        {
            string cadena = "";
            int contar1 = 0;
            int contar2 = 0;
            int contar3 = 0;
            int contar4 = 0;
            int contar5 = 0;
            int contar6 = 0;
            int contar7 = 0;
            int contar8 = 0;
            int contar9 = 0;
            int contar10 = 0;
            int contar11 = 0;
            int contar12 = 0;
            int contar13 = 0;
            int contar14 = 0;
            int contar15 = 0;
            int contar16 = 0;
            List<List<string>> datos = (List<List<string>>)Session["lectura"];
            for (int j = 0; j < ganadores.Count(); j++)
            {
                for (int i = 0; i < datos.Count(); i++)
                {
                    List<string> actual = datos[i];
                    for (int k = 0; k < actual.Count(); k++)
                    {
                        if (ganadores[j] == actual[k])
                        {
                            if (i == 0)
                            {
                                contar1++;
                            }
                            if (i == 1)
                            {
                                contar2++;
                            }
                            if (i == 2)
                            {
                                contar3++;
                            }
                            if (i == 3)
                            {
                                contar4++;
                            }
                            if (i == 4)
                            {
                                contar5++;
                            }
                            if (i == 5)
                            {
                                contar6++;
                            }
                            if (i == 6)
                            {
                                contar7++;
                            }
                            if (i == 7)
                            {
                                contar8++;
                            }
                            if (i == 8)
                            {
                                contar9++;
                            }
                            if (i == 9)
                            {
                                contar10++;
                            }
                            if (i == 10)
                            {
                                contar11++;
                            }
                            if (i == 11)
                            {
                                contar12++;
                            }
                            if (i == 12)
                            {
                                contar13++;
                            }
                            if (i == 13)
                            {
                                contar14++;
                            }
                            if (i == 14)
                            {
                                contar15++;
                            }
                            if (i == 15)
                            {
                                contar16++;
                            }
                        }
                    }
                }
            }
                if (contar2>contar1)
                {
                    if (contar2 != contar1)
                    {
                        cadena = "equipo2";
                    }
                }
                else
                {
                    if (contar2 != contar1)
                    {
                        cadena = "equipo1";
                    }
                }
                if (contar4 > contar3)
                {
                    if (contar4 != contar3)
                    {
                        cadena = cadena + "&" + "equipo4";
                    }
                }
                else
                {
                    if (contar4 != contar3)
                    {
                        cadena = cadena + "&" + "equipo3";
                    }
                }
                if (contar6 > contar5)
                {
                    if (contar6 != contar5)
                    {
                        cadena = cadena + "&" + "equipo6";
                    }
                }
                else
                {
                    if (contar6 != contar5)
                    {
                        cadena = cadena + "&" + "equipo5";
                    }
                }
                if (contar8 > contar7)
                {
                    if (contar8 != contar7)
                    {
                        cadena = cadena + "&" + "equipo8";
                    }
                }
                else
                {
                    if (contar8 != contar7)
                    {
                        cadena = cadena + "&" + "equipo7";
                    }
                }
                if (contar10 > contar9)
                {
                    if (contar10 != contar9)
                    {
                        cadena = cadena + "&" + "equipo10";
                    }
                }
                else
                {
                    if (contar10 != contar9)
                    {
                        cadena = cadena + "&" + "equipo9";
                    }
                }
                if (contar12 > contar11)
                {
                    if (contar12 != contar11)
                    {
                        cadena = cadena + "&" + "equipo12";
                    }
                }
                else
                {
                    if (contar12 != contar11)
                    {
                        cadena = cadena + "&" + "equipo11";
                    }
                }
                if (contar14 > contar13)
                {
                    if (contar14 != contar13)
                    {
                        cadena = cadena + "&" + "equipo14";
                    }
                }
                else
                {
                    if (contar14 != contar13)
                    {
                        cadena = cadena + "&" + "equipo13";
                    }
                }
                if (contar16 > contar15)
                {
                    if(contar16 != contar15)
                    {
                        cadena = cadena + "&" + "equipo16";
                    }
                }
                else
                {
                    if (contar16 != contar15)
                    {
                        cadena = cadena + "&" + "equipo15";
                    }
                
            }
            List<List<string>> datos1 = datos;
            List<List<string>> datos2 = new List<List<string>> { };
            for (int j = 0; j < ganadores.Count(); j++)
            {
                for (int i = 0; i < datos1.Count(); i++)
                {
                    List<string> actual = datos1[i];
                    for (int k = 0; k < actual.Count(); k++)
                    {
                        if (actual[k] == ganadores[j])
                        {
                            for (int l = 0; l < datos2.Count(); l++)
                            {
                                List<string> actual2 = datos2[l];
                                if(actual[0] == actual2[0])
                                {
                                    datos2.Remove(actual);
                                }
                            }
                            datos2.Add(actual);
                        }
                    }
                }
            }
            Session["cadenaUsar"] = datos2;
            return cadena;
        }

        public string PunteoOC(List<string> ganadores)
        {
            string cadena = "";
            int contar1 = 0;
            int contar2 = 0;
            int contar3 = 0;
            int contar4 = 0;
            int contar5 = 0;
            int contar6 = 0;
            int contar7 = 0;
            int contar8 = 0;
            int contar9 = 0;
            int contar10 = 0;
            int contar11 = 0;
            int contar12 = 0;
            int contar13 = 0;
            int contar14 = 0;
            int contar15 = 0;
            int contar16 = 0;
            List<List<string>> datos = (List<List<string>>)Session["cadenaUsar"];
            for (int j = 0; j < ganadores.Count(); j++)
            {
                for (int i = 0; i < datos.Count(); i++)
                {
                    List<string> actual = datos[i];
                    for (int k = 0; k < actual.Count(); k++)
                    {
                        if (ganadores[j] == actual[k])
                        {
                            if (i == 0)
                            {
                                contar1++;
                            }
                            if (i == 1)
                            {
                                contar2++;
                            }
                            if (i == 2)
                            {
                                contar3++;
                            }
                            if (i == 3)
                            {
                                contar4++;
                            }
                            if (i == 4)
                            {
                                contar5++;
                            }
                            if (i == 5)
                            {
                                contar6++;
                            }
                            if (i == 6)
                            {
                                contar7++;
                            }
                            if (i == 7)
                            {
                                contar8++;
                            }
                            if (i == 8)
                            {
                                contar9++;
                            }
                            if (i == 9)
                            {
                                contar10++;
                            }
                            if (i == 10)
                            {
                                contar11++;
                            }
                            if (i == 11)
                            {
                                contar12++;
                            }
                            if (i == 12)
                            {
                                contar13++;
                            }
                            if (i == 13)
                            {
                                contar14++;
                            }
                            if (i == 14)
                            {
                                contar15++;
                            }
                            if (i == 15)
                            {
                                contar16++;
                            }
                        }
                    }
                }
            }
                if (contar2 > contar1)
                {
                    if (contar2 != contar1)
                    {
                        cadena = "equipo18";
                    }
                }
                else
                {
                    if (contar2 != contar1)
                    {
                        cadena = "equipo17";
                    }
                }
                if (contar4 > contar3)
                {
                    if (contar4 != contar3)
                    {
                        cadena = cadena + "&" + "equipo20";
                    }
                }
                else
                {
                    if (contar4 != contar3)
                    {
                        cadena = cadena + "&" + "equipo19";
                    }
                }
                if (contar6 > contar5)
                {
                    if (contar6 != contar5)
                    {
                        cadena = cadena + "&" + "equipo22";
                    }
                }
                else
                {
                    if (contar6 != contar5)
                    {
                        cadena = cadena + "&" + "equipo21";
                    }
                }
                if (contar8 > contar7)
                {
                    if (contar8 != contar7)
                    {
                        cadena = cadena + "&" + "equipo24";
                    }
                }
                else
                {
                    if (contar8 != contar7)
                    {
                        cadena = cadena + "&" + "equipo23";
                    }
                }

            List<List<string>> datos1 = datos;
            List<List<string>> datos2 = new List<List<string>> { };
            for (int j = 0; j < ganadores.Count(); j++)
            {
                for (int i = 0; i < datos1.Count(); i++)
                {
                    List<string> actual = datos1[i];
                    for (int k = 0; k < actual.Count(); k++)
                    {
                        if (actual[k] == ganadores[j])
                        {
                            for (int l = 0; l < datos2.Count(); l++)
                            {
                                List<string> actual2 = datos2[l];
                                if (actual[0] == actual2[0])
                                {
                                    datos2.Remove(actual);
                                }
                            }
                            datos2.Add(actual);
                        }
                    }
                }
            }
            Session["cadenaUsar"] = datos2;
            return cadena;
        }

        public string PunteoME(List<string> ganadores)
        {
            string cadena = "";
            int contar1 = 0;
            int contar2 = 0;
            int contar3 = 0;
            int contar4 = 0;
            List<List<string>> datos = (List<List<string>>)Session["cadenaUsar"];
            for (int j = 0; j < ganadores.Count(); j++)
            {
                for (int i = 0; i < datos.Count(); i++)
                {
                    List<string> actual = datos[i];
                    for (int k = 0; k < actual.Count(); k++)
                    {
                        if (ganadores[j] == actual[k])
                        {
                            if (i == 0)
                            {
                                contar1++;
                            }
                            if (i == 1)
                            {
                                contar2++;
                            }
                            if (i == 2)
                            {
                                contar3++;
                            }
                            if (i == 3)
                            {
                                contar4++;
                            }
                        }
                    }
                }
            }
            if (contar3 > contar1)
            {
                if (contar3 != contar1)
                {
                    cadena = "equipo27";
                }
            }
            else
            {
                if (contar3 != contar1)
                {
                    cadena = "equipo25";
                }
            }
            if (contar4 > contar2)
            {
                if (contar4 != contar2)
                {
                    cadena = cadena + "&" + "equipo28";
                }
            }
            else
            {
                if (contar4 != contar2)
                {
                    cadena = cadena + "&" + "equipo26";
                }
            }

            List<List<string>> datos1 = datos;
            List<List<string>> datos2 = new List<List<string>> { };
            for (int j = 0; j < ganadores.Count(); j++)
            {
                for (int i = 0; i < datos1.Count(); i++)
                {
                    List<string> actual = datos1[i];
                    for (int k = 0; k < actual.Count(); k++)
                    {
                        if (actual[k] == ganadores[j])
                        {
                            for (int l = 0; l < datos2.Count(); l++)
                            {
                                List<string> actual2 = datos2[l];
                                if (actual[0] == actual2[0])
                                {
                                    datos2.Remove(actual);
                                }
                            }
                            datos2.Add(actual);
                        }
                    }
                }
            }
            Session["cadenaUsar"] = datos2;
            return cadena;
        }

        public string final(List<string> ganadores)
        {
            string cadena = "";
            List<string> conteo1 = new List<string> { };
            List<string> conteo2 = new List<string> { };
            conteo1.Add(ganadores[0]);
            for (int i = 1; i < ganadores.Count(); i++)
            {
                if (conteo1.Contains(ganadores[i]))
                {
                    conteo1.Add(ganadores[i]);
                }
                else
                {
                    conteo2.Add(ganadores[i]);
                }
                
            }
            int contador1 = conteo1.Count();
            int contador2 = conteo2.Count();
            if (contador1 > contador2)
            {
                cadena = conteo1[0];
            }
            else
            {
                cadena = conteo2[0];
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