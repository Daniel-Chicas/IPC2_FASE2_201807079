using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Ficha
    {
        public string color { get; set; }
        public string columna { get; set; }
        public int fila { get; set; }
    }

    public class Personalizado
    {
        public string filas { get; set; }
        public string columnas { get; set; }
        public string colores1 { get; set; }
        public string colores2 { get; set; }
        public string modalidad { get; set; }
    }

    public class Torneo
    {
        public string nombreCampeonato { get; set; }
        public string nombreEquipo1 { get; set; }
        public string nombreEquipo2 { get; set; }
        public string nombreEquipo3 { get; set; }
        public string nombreEquipo4 { get; set; }
        public string nombreEquipo5 { get; set; }
        public string nombreEquipo6 { get; set; }
        public string nombreEquipo7 { get; set; }
        public string nombreEquipo8 { get; set; }
        public string nombreEquipo9 { get; set; }
        public string nombreEquipo10 { get; set; }
        public string nombreEquipo11 { get; set; }
        public string nombreEquipo12 { get; set; }
        public string nombreEquipo13 { get; set; }
        public string nombreEquipo14 { get; set; }
        public string nombreEquipo15 { get; set; }
        public string nombreEquipo16 { get; set; }
        public string jugadores1 { get; set; }
        public string jugadores2 { get; set; }
        public string jugadores3 { get; set; }
       
    }
}