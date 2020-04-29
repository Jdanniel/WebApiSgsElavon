using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ORDEN_COMPRA_NO_FACTURA")]
    public partial class BdOrdenCompraNoFactura
    {
        [Column("ID_ORDEN_COMPRA_NO_FACTURA")]
        public int IdOrdenCompraNoFactura { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
        [Column("NO_FACTURA")]
        [StringLength(255)]
        public string NoFactura { get; set; }
        [Column("FEC_FACTURA", TypeName = "datetime")]
        public DateTime? FecFactura { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
