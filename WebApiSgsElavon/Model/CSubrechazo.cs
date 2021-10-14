using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SUBRECHAZO")]
    public partial class CSubrechazo
    {
        [Key]
        [Column("ID_SUBRECHAZO")]
        public int IdSubrechazo { get; set; }
        [Column("SUBRECHAZO")]
        public string Subrechazo { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
        [Column("USUARIO_ALTA")]
        public int? UsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("IS_PROGRAMADO")]
        public int? IsProgramado { get; set; }
    }
}
