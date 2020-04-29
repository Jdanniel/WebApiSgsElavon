using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_COTIZACIONES_3M_DET")]
    public partial class BdCotizaciones3mDet
    {
        [Key]
        [Column("id_det_cotizacion")]
        public int IdDetCotizacion { get; set; }
        [Column("id_insumo")]
        public int? IdInsumo { get; set; }
        [Column("cantidad")]
        public int? Cantidad { get; set; }
        [Column("precio")]
        public double? Precio { get; set; }
        [Column("id_um")]
        public int? IdUm { get; set; }
        [Column("descuento")]
        public double? Descuento { get; set; }
        [Column("id_cotizacion")]
        public int? IdCotizacion { get; set; }
        [Column("total")]
        public double? Total { get; set; }
    }
}
