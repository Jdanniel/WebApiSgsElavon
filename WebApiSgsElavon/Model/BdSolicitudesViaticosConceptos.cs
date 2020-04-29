using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_VIATICOS_CONCEPTOS")]
    public partial class BdSolicitudesViaticosConceptos
    {
        [Column("ID_SOLICITUD_VIATICOS_CONCEPTO")]
        public int IdSolicitudViaticosConcepto { get; set; }
        [Column("ID_SOLICITUD_VIATICOS")]
        public int IdSolicitudViaticos { get; set; }
        [Column("ID_VIATICO")]
        public int IdViatico { get; set; }
        [Column("CANTIDAD_SOLICITADA", TypeName = "numeric(18, 2)")]
        public decimal? CantidadSolicitada { get; set; }
        [Column("CANTIDAD_AUTORIZADA", TypeName = "numeric(18, 2)")]
        public decimal? CantidadAutorizada { get; set; }
        [Column("CANTIDAD_COMPROBADA", TypeName = "numeric(18, 2)")]
        public decimal? CantidadComprobada { get; set; }
        [Column("ADEUDO", TypeName = "numeric(18, 2)")]
        public decimal? Adeudo { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("FROM_AUTOMATIZACION")]
        public int? FromAutomatizacion { get; set; }
        [Column("KILOMETROS")]
        [StringLength(20)]
        public string Kilometros { get; set; }
        [Column("OBSERVACIONES")]
        [StringLength(100)]
        public string Observaciones { get; set; }
        [Column("CANTIDAD_SOLICITADA_REAL")]
        [StringLength(20)]
        public string CantidadSolicitadaReal { get; set; }

        [ForeignKey("IdSolicitudViaticos")]
        [InverseProperty("BdSolicitudesViaticosConceptos")]
        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
        [ForeignKey("IdViatico")]
        [InverseProperty("BdSolicitudesViaticosConceptos")]
        public virtual CViaticos IdViaticoNavigation { get; set; }
    }
}
