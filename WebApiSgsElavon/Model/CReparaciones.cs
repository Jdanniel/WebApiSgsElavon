using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_REPARACIONES")]
    public partial class CReparaciones
    {
        [Key]
        [Column("ID_REPARACION")]
        public int IdReparacion { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("DESC_REPARACION")]
        [StringLength(250)]
        public string DescReparacion { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
