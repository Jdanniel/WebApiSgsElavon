using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ORDEN_COMPRA")]
    public partial class BdOrdenCompra
    {
        [Column("ID_ORDEN_COMPRA")]
        public int IdOrdenCompra { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("ID_STATUS_ORDEN_COMPRA")]
        public int? IdStatusOrdenCompra { get; set; }
        [Column("FEC_ORDEN_COMPRA", TypeName = "datetime")]
        public DateTime? FecOrdenCompra { get; set; }
    }
}
