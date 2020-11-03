using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;
using System.Net;
using WebApplication1.Entity;
using Microsoft.Ajax.Utilities;

namespace WebApplication1.Controllers
{
    public class perfilController : Controller
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-G5NRNFT\\SQLEXPRESS; database=BD_IPC2; integrated security = true");


        private BD_IPC2Entities db = new BD_IPC2Entities();
        public ActionResult Index()
        {
            return View();
        }
        public object DatosUsuario()
        {
            string cadena = "";
            var pusuario = (string)Session["usuario"];
            Usuario datosUsuario = new Usuario();
            Entity.Usuario usuario = db.Usuario.Where(s => s.Usuario1 == pusuario).FirstOrDefault();
            string nombreCompleto;
            string usuarioNo;
            string paisCom = "";
            if (usuario != null)
            {
                string nombre = usuario.Nombre;
                string apellido = usuario.Apellidos;
                string usuarioNombre = usuario.Usuario1;
                DateTime fechaNacimiento = usuario.FechaNacimiento;
                string correo = usuario.Correo;
                int pais= usuario.Pais;
                nombreCompleto = nombre+" "+apellido;
                usuarioNo = usuarioNombre;
                switch (pais)
                {
                    case 1:
                        paisCom = "Alemania";
                        break;
                    case 2:
                        paisCom = "Argentina";
                        break;
                    case 3:
                        paisCom = "Bahamas";
                        break;
                    case 4:
                        paisCom = "Barbados";
                        break;
                    case 5:
                        paisCom = "Belice";
                        break;
                    case 6:
                        paisCom = "Bolivia";
                        break;
                    case 7:
                        paisCom = "Brasil";
                        break;
                    case 8:
                        paisCom = "Canadá";
                        break;
                    case 9:
                        paisCom = "Chile";
                        break;
                    case 10:
                        paisCom = "China";
                        break;
                    case 11:
                        paisCom = "Ciudad del Vatican";
                        break;
                    case 12:
                        paisCom = "Colombia";
                        break;
                    case 13:
                        paisCom = "Costa Rica";
                        break;
                    case 14:
                        paisCom = "Croacia";
                        break;
                    case 15:
                        paisCom = "Cuba";
                        break;
                    case 16:
                        paisCom = "Dominica";
                        break;
                    case 17:
                        paisCom = "Ecuador";
                        break;
                    case 18:
                        paisCom = "España";
                        break;
                    case 19:
                        paisCom = "Estados Unidos";
                        break;
                    case 20:
                        paisCom = "Grecia";
                        break;
                    case 21:
                        paisCom = "Guatemala";
                        break;
                    case 22:
                        paisCom = "Guyana";
                        break;
                    case 23:
                        paisCom = "Honduras";
                        break;
                    case 24:
                        paisCom = "Italia";
                        break;
                    case 25:
                        paisCom = "Jamaica";
                        break;
                    case 26:
                        paisCom = "Japón";
                        break;
                    case 27:
                        paisCom = "Maldivas";
                        break;
                    case 28:
                        paisCom = "Marruecos";
                        break;
                    case 29:
                        paisCom = "México";
                        break;
                    case 30:
                        paisCom = "Mónaco";
                        break;
                    case 31:
                        paisCom = "Nicaragua";
                        break;
                    case 32:
                        paisCom = "Noruega";
                        break;
                    case 33:
                        paisCom = "Panamá";
                        break;
                    case 34:
                        paisCom = "Paraguay";
                        break;
                    case 35:
                        paisCom = "Perú";
                        break;
                    case 36:
                        paisCom = "Reino Unido";
                        break;
                    case 37:
                        paisCom = "Rusia";
                        break;
                    case 38:
                        paisCom = "Santa Lucía";
                        break;
                    case 39:
                        paisCom = "Singapur";
                        break;
                    case 40:
                        paisCom = "Suecia";
                        break;
                    case 41:
                        paisCom = "Suiza";
                        break;
                    case 42:
                        paisCom = "Trinidad y Tobago";
                        break;
                    case 43:
                        paisCom = "Uruguay";
                        break;
                    case 44:
                        paisCom = "Venezuela";
                        break;
                    case 45:
                        paisCom = "Vietnam";
                        break;
                    case 46:
                        paisCom = "Yemen";
                        break;
                    case 47:
                        paisCom = "Yibuti";
                        break;
                    case 48:
                        paisCom = "Zambia";
                        break;
                    case 49:
                        paisCom = "Zimbabue";
                        break;
                    case 50:
                        paisCom = "Otro";
                        break;
                }
                int edadCompleta = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
                cadena = nombreCompleto + "&"+usuarioNo+"&"+ edadCompleta+"&"+correo+"&"+paisCom;
            }
            return cadena;
        }

        public string datosJuego()
        {
            var pusuario = (string)Session["usuario"];
            SqlCommand comando = new SqlCommand("SELECT * FROM Partida WHERE UsuarioId = "+"'"+pusuario+"'", conexion);
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            List<List<string>> equipo = new List<List<string>> { };
            
            while (leer.Read() == true)
            {
                List<string> info = new List<string> { };
                string puntos = leer["Puntaje"].ToString();
                string colorFicha = leer["ColorFicha"].ToString();
                string movimientos = leer["CantidadMovimientos"].ToString();
                string estado = leer["EstadoPartida"].ToString();
                string tipo = leer["TipoPartida"].ToString();
                string fecha = leer["FechaPartida"].ToString();
                info.Add(puntos);
                info.Add(colorFicha);
                info.Add(movimientos);
                info.Add(estado);
                info.Add(tipo);
                info.Add(fecha);
                equipo.Add(info);
            }
            conexion.Close();
            string cadena = "";
            for (int i = 0; i < equipo.Count(); i++)
            {
                List<string> actual = equipo[i];
                for (int j = 0; j < actual.Count(); j++)
                {
                    cadena = cadena + actual[j];
                    cadena = cadena + "|";
                }
                cadena = cadena + "&";
            }
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
    }
}