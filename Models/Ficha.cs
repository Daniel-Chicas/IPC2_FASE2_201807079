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
}