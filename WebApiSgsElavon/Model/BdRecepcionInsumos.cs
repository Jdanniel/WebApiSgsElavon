using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_RECEPCION_INSUMOS")]
    public partial class BdRecepcionInsumos
    {
        [Column("ID_RECEPCION_INSUMO")]
        public int IdRecepcionInsumo { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDAD_RECEPCIONADA")]
        public double? CantidadRecepcionada { get; set; }
    }
}
