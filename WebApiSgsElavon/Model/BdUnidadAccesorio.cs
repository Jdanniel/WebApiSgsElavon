using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDAD_ACCESORIO")]
    public partial class BdUnidadAccesorio
    {
        [Key]
        [Column("ID_UNIDAD_ACCESORIO")]
        public int IdUnidadAccesorio { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("ID_ACCESORIO")]
        public int IdAccesorio { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("NO_SERIE")]
        [StringLength(50)]
        public string NoSerie { get; set; }
        [Column("ID_STATUS_ACCESORIO")]
        public int? IdStatusAccesorio { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }

        [ForeignKey("IdAccesorio")]
        [InverseProperty("BdUnidadAccesorio")]
        public virtual CAccesorios IdAccesorioNavigation { get; set; }
        [ForeignKey("IdStatusAccesorio")]
        [InverseProperty("BdUnidadAccesorio")]
        public virtual CStatusAccesorio IdStatusAccesorioNavigation { get; set; }
        [ForeignKey("IdUnidad")]
        [InverseProperty("BdUnidadAccesorio")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
