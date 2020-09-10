namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Usuarioid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string Apellidos { get; set; }

        [Key]
        [Column("Usuario", Order = 3)]
        [StringLength(150)]
        public string Usuario1 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(150)]
        public string Contraseña { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(150)]
        public string Correo { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pais { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstadoId { get; set; }

        public DateTime? FechaUltMod { get; set; }
    }
}
