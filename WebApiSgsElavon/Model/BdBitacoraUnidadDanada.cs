using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_UNIDAD_DANADA")]
    public partial class BdBitacoraUnidadDanada
    {
        [Column("ID_BITACORA_UNIDAD_DANADA")]
        public int IdBitacoraUnidadDanada { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("IS_DANIADA_ACTUAL")]
        public int? IsDaniadaActual { get; set; }
        [Column("IS_DANIADA_NUEVO")]
        public int? IsDaniadaNuevo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }

        [ForeignKey("IdUnidad")]
        [InverseProperty("BdBitacoraUnidadDanada")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
