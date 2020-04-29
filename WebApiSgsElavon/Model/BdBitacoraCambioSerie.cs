using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_CAMBIO_SERIE")]
    public partial class BdBitacoraCambioSerie
    {
        [Column("ID_BITACORA")]
        public int IdBitacora { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("SERIE")]
        [StringLength(250)]
        public string Serie { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("NO_SERIE_NEW")]
        [StringLength(255)]
        public string NoSerieNew { get; set; }
    }
}
