using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_ITEM_ORDEN_COMPRA")]
    public partial class CTipoItemOrdenCompra
    {
        [Column("ID_TIPO_ITEM_ORDEN_COMPRA")]
        public int IdTipoItemOrdenCompra { get; set; }
        [Column("DESC_TIPO_ITEM_ORDEN_COMPRA")]
        public string DescTipoItemOrdenCompra { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
