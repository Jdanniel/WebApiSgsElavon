using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SOLICITUDES_VIATICOS")]
    public partial class BdBitacoraSolicitudesViaticos
    {
        [Key]
        [Column("ID_BITACORA_SOLICITUD_VIATICOS")]
        public int IdBitacoraSolicitudViaticos { get; set; }
        [Column("ID_SOLICITUD_VIATICOS")]
        public int IdSolicitudViaticos { get; set; }
        [Column("ID_STATUS_SOLICITUD_VIATICOS_INI")]
        public int? IdStatusSolicitudViaticosIni { get; set; }
        [Column("ID_STATUS_SOLICITUD_VIATICOS_FIN")]
        public int IdStatusSolicitudViaticosFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }

        [ForeignKey("IdSolicitudViaticos")]
        [InverseProperty("BdBitacoraSolicitudesViaticos")]
        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudViaticosFin")]
        [InverseProperty("BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation")]
        public virtual CStatusSolicitudViaticos IdStatusSolicitudViaticosFinNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudViaticosIni")]
        [InverseProperty("BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation")]
        public virtual CStatusSolicitudViaticos IdStatusSolicitudViaticosIniNavigation { get; set; }
    }
}
