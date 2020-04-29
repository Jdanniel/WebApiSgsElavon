using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ORDEN_COMPRA_INSUMOS")]
    public partial class BdOrdenCompraInsumos
    {
        [Column("ID_ORDEN_COMPRA_INSUMO")]
        public int IdOrdenCompraInsumo { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
        [Column("ID_INSUMO")]
        public int? IdInsumo { get; set; }
        [Column("CANTIDAD")]
        public double? Cantidad { get; set; }
        [Column("COSTO")]
        public double? Costo { get; set; }
        [Column("TOTAL")]
        public double? Total { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("IS_RECIBIDO")]
        public int? IsRecibido { get; set; }
    }
}
