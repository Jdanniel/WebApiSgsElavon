using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SOLICITUD_DEVOLUCION")]
    public partial class BdBitacoraSolicitudDevolucion
    {
        [Key]
        [Column("ID_BITACORA_SOLICITUD_DEVOLUCION")]
        public int IdBitacoraSolicitudDevolucion { get; set; }
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int IdSolicitudDevolucion { get; set; }
        [Column("ID_STATUS_SOLICITUD_DEVOLUCION_INI")]
        public int? IdStatusSolicitudDevolucionIni { get; set; }
        [Column("ID_STATUS_SOLICITUD_DEVOLUCION_FIN")]
        public int? IdStatusSolicitudDevolucionFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }

        [ForeignKey("IdStatusSolicitudDevolucionFin")]
        [InverseProperty("BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionFinNavigation")]
        public virtual CStatusSolicitudDevolucion IdStatusSolicitudDevolucionFinNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudDevolucionIni")]
        [InverseProperty("BdBitacoraSolicitudDevolucionIdStatusSolicitudDevolucionIniNavigation")]
        public virtual CStatusSolicitudDevolucion IdStatusSolicitudDevolucionIniNavigation { get; set; }
        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdBitacoraSolicitudDevolucion")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}
