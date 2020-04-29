using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REPARACION_UNIDAD")]
    public partial class BdReparacionUnidad
    {
        [Key]
        [Column("ID_REPARACION_UNIDAD")]
        public int IdReparacionUnidad { get; set; }
        [Column("ID_REPARACION")]
        public int? IdReparacion { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_STATUS_REPARACION")]
        public int? IdStatusReparacion { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 0)")]
        public decimal? Costo { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_STATUS", TypeName = "smalldatetime")]
        public DateTime? FecStatus { get; set; }
        [Column("ID_USUARIO_STATUS")]
        public int? IdUsuarioStatus { get; set; }
        [Column("FEC_REPARACION", TypeName = "smalldatetime")]
        public DateTime? FecReparacion { get; set; }
        [Column("ID_USUARIO_REPARACION")]
        public int? IdUsuarioReparacion { get; set; }
        [Column("ID_NIVEL_REPARACION")]
        public int? IdNivelReparacion { get; set; }
        [Column("ID_TIPO_REPARACION")]
        public int? IdTipoReparacion { get; set; }
        [Column("ID_SOFTWARE")]
        public int? IdSoftware { get; set; }
        [Column("ID_LLAVE")]
        public int? IdLlave { get; set; }
        [Column("DESC_REPARACION")]
        public string DescReparacion { get; set; }
    }
}
