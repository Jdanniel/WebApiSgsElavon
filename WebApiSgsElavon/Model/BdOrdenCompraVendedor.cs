using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ORDEN_COMPRA_VENDEDOR")]
    public partial class BdOrdenCompraVendedor
    {
        [Column("ID_ORDEN_COMPRA_VENDEDOR")]
        public int IdOrdenCompraVendedor { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
        [Column("ID_VENDEDOR")]
        public int? IdVendedor { get; set; }
        [Column("ARCHER_VENDOR_ID")]
        public int? ArcherVendorId { get; set; }
        [Column("MONEDA")]
        [StringLength(255)]
        public string Moneda { get; set; }
        [Column("TERMINO_PAGO")]
        [StringLength(255)]
        public string TerminoPago { get; set; }
        [Column("NO_ORDEN_COMPRA")]
        [StringLength(255)]
        public string NoOrdenCompra { get; set; }
        [Column("CENTRO_COSTO")]
        [StringLength(255)]
        public string CentroCosto { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }
        [Column("ID_TIPO_ITEM_ORDEN_COMPRA")]
        public int? IdTipoItemOrdenCompra { get; set; }
    }
}
