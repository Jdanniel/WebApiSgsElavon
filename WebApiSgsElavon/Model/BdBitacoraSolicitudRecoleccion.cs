using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SOLICITUD_RECOLECCION")]
    public partial class BdBitacoraSolicitudRecoleccion
    {
        [Key]
        [Column("ID_BITACORA_SOLICITUD_RECOLECCION")]
        public int IdBitacoraSolicitudRecoleccion { get; set; }
        [Column("ID_SOLICITUD_RECOLECCION")]
        public int IdSolicitudRecoleccion { get; set; }
        [Column("ID_STATUS_SOLICITUD_RECOLECCION_INI")]
        public int? IdStatusSolicitudRecoleccionIni { get; set; }
        [Column("ID_STATUS_SOLICITUD_RECOLECCION_FIN")]
        public int? IdStatusSolicitudRecoleccionFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [ForeignKey("IdSolicitudRecoleccion")]
        [InverseProperty("BdBitacoraSolicitudRecoleccion")]
        public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudRecoleccionFin")]
        [InverseProperty("BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionFinNavigation")]
        public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionFinNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudRecoleccionIni")]
        [InverseProperty("BdBitacoraSolicitudRecoleccionIdStatusSolicitudRecoleccionIniNavigation")]
        public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionIniNavigation { get; set; }
    }
}
