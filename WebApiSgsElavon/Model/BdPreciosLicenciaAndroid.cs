using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PRECIOS_LICENCIA_ANDROID")]
    public partial class BdPreciosLicenciaAndroid
    {
        [Column("ID_PRECIO_LICENCIA")]
        public int IdPrecioLicencia { get; set; }
        [Column("RANGO_LICENCIA")]
        public string RangoLicencia { get; set; }
        [Column("COSTO_MENSUAL", TypeName = "decimal(8, 2)")]
        public decimal? CostoMensual { get; set; }
    }
}
