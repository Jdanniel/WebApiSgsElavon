using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COMPROMISOS_COMPROMISO")]
    public partial class BdCompromisosCompromiso
    {
        [Key]
        [Column("ID_COMPROMISOS_COMPROMISO")]
        public int IdCompromisosCompromiso { get; set; }
        [Column("ID_COMPROMISO")]
        public int? IdCompromiso { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "smalldatetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("COMPROMISO")]
        [StringLength(255)]
        public string Compromiso { get; set; }
    }
}
