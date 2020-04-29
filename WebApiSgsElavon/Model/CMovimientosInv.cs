using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MOVIMIENTOS_INV")]
    public partial class CMovimientosInv
    {
        [Column("ID_MOV_INVENTARIO")]
        public int IdMovInventario { get; set; }
        [Column("DESC_MOV_INVENTARIO")]
        public string DescMovInventario { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
