using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_NEGOCIOS_COORDENADAS")]
    public partial class BdBitacoraNegociosCoordenadas
    {
        [Column("ID_BITCORA_NEGOCIO_COORDENADA")]
        public int IdBitcoraNegocioCoordenada { get; set; }
        [Column("ID_NEGOCIO")]
        public int? IdNegocio { get; set; }
        [Column("LATITUD", TypeName = "numeric(20, 15)")]
        public decimal? Latitud { get; set; }
        [Column("LONGITUD", TypeName = "numeric(20, 15)")]
        public decimal? Longitud { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
    }
}
