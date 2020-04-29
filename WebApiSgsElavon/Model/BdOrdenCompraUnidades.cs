using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ORDEN_COMPRA_UNIDADES")]
    public partial class BdOrdenCompraUnidades
    {
        [Column("ID_ORDEN_COMPRA_UNIDAD")]
        public int IdOrdenCompraUnidad { get; set; }
        [Column("ID_ORDEN_COMPRA")]
        public int? IdOrdenCompra { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
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
