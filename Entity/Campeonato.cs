//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Campeonato
    {
        public int IdTorneo { get; set; }
        public string UsuarioIdCreador { get; set; }
        public string NombreTorneo { get; set; }
        public string CantidadEquipos { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string Estado { get; set; }
    }
}
