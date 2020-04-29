using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SOLICITUDES_ALMACEN")]
    public partial class BdBitacoraSolicitudesAlmacen
    {
        [Column("ID_BITACORA_SOLICITUD_ALMACEN")]
        public int IdBitacoraSolicitudAlmacen { get; set; }
        [Column("ID_SOLICITUD_ALMACEN")]
        public int? IdSolicitudAlmacen { get; set; }
        [Column("ID_STATUS_SOLICITUD_ALMACEN_INI")]
        public int? IdStatusSolicitudAlmacenIni { get; set; }
        [Column("ID_STATUS_SOLICITUD_ALMACEN_FIN")]
        public int? IdStatusSolicitudAlmacenFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("COMENTARIO", TypeName = "text")]
        public string Comentario { get; set; }

        [ForeignKey("IdStatusSolicitudAlmacenFin")]
        [InverseProperty("BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigation")]
        public virtual CStatusSolicitudAlmacen IdStatusSolicitudAlmacenFinNavigation { get; set; }
        [ForeignKey("IdStatusSolicitudAlmacenIni")]
        [InverseProperty("BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigation")]
        public virtual CStatusSolicitudAlmacen IdStatusSolicitudAlmacenIniNavigation { get; set; }
    }
}
