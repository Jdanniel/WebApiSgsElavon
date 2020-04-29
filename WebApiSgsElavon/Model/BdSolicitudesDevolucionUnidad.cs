using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_DEVOLUCION_UNIDAD")]
    public partial class BdSolicitudesDevolucionUnidad
    {
        [Key]
        [Column("ID_SOLICITUD_DEVOLUCION_UNIDAD")]
        public int IdSolicitudDevolucionUnidad { get; set; }
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int IdSolicitudDevolucion { get; set; }
        [Column("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [Column("NO_SERIE")]
        [StringLength(250)]
        public string NoSerie { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_RECIBIDO_RETORNO")]
        public int? IsRecibidoRetorno { get; set; }
        [Column("ID_STATUS_UNIDAD_INI")]
        public int? IdStatusUnidadIni { get; set; }

        [ForeignKey("IdUnidad")]
        [InverseProperty("BdSolicitudesDevolucionUnidad")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdSolicitudesDevolucionUnidad")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}
