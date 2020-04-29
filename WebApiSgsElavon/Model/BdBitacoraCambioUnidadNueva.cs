using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_CAMBIO_UNIDAD_NUEVA")]
    public partial class BdBitacoraCambioUnidadNueva
    {
        [Column("ID_BITACORA_CAMBIO_UNIDAD_NUEVA")]
        public int IdBitacoraCambioUnidadNueva { get; set; }
        [Column("ID_BITACORA_UNIDAD")]
        public int? IdBitacoraUnidad { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("IS_NUEVA")]
        public int? IsNueva { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
