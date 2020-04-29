using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_UNIDAD")]
    public partial class BdBitacoraUnidad
    {
        [Column("ID_BITACORA_UNIDAD")]
        public int IdBitacoraUnidad { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("ID_STATUS_UNIDAD_INI")]
        public int? IdStatusUnidadIni { get; set; }
        [Column("ID_STATUS_UNIDAD_FIN")]
        public int? IdStatusUnidadFin { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int? IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int? IdResponsable { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }

        [ForeignKey("IdStatusUnidadFin")]
        [InverseProperty("BdBitacoraUnidadIdStatusUnidadFinNavigation")]
        public virtual CStatusUnidad IdStatusUnidadFinNavigation { get; set; }
        [ForeignKey("IdStatusUnidadIni")]
        [InverseProperty("BdBitacoraUnidadIdStatusUnidadIniNavigation")]
        public virtual CStatusUnidad IdStatusUnidadIniNavigation { get; set; }
        [ForeignKey("IdTipoResponsable")]
        [InverseProperty("BdBitacoraUnidad")]
        public virtual CTipoResponsable IdTipoResponsableNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdBitacoraUnidad")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
