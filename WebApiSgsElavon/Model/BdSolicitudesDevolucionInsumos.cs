using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUDES_DEVOLUCION_INSUMOS")]
    public partial class BdSolicitudesDevolucionInsumos
    {
        [Key]
        [Column("ID_SOLICITUD_DEVOLUCION_INSUMO")]
        public int IdSolicitudDevolucionInsumo { get; set; }
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int IdSolicitudDevolucion { get; set; }
        [Column("ID_INSUMO")]
        public int IdInsumo { get; set; }
        [Column("CANTIDAD")]
        [StringLength(250)]
        public string Cantidad { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("IS_RECIBIDO_RETORNO")]
        public int? IsRecibidoRetorno { get; set; }
        [Column("ID_STATUS_INSUMO_INI")]
        public int? IdStatusInsumoIni { get; set; }

        [ForeignKey("IdUsuarioAlta")]
        [InverseProperty("BdSolicitudesDevolucionInsumos")]
        public virtual CUsuarios IdUsuarioAltaNavigation { get; set; }
    }
}
