using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_VALIDACION_DEVOLUCIONES")]
    public partial class BdBitacoraValidacionDevoluciones
    {
        [Key]
        [Column("ID_BITACORA_VALIDACION_DEVOLUCIONES")]
        public int IdBitacoraValidacionDevoluciones { get; set; }
        [Column("ID_SOLICITUD_DEVOLUCION")]
        public int? IdSolicitudDevolucion { get; set; }
        [Column("ID_STATUS_INI")]
        public int? IdStatusIni { get; set; }
        [Column("ID_STATUS_FIN")]
        public int? IdStatusFin { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("DOCUMENTO")]
        [StringLength(250)]
        public string Documento { get; set; }
        [Column("COMENTARIO")]
        [StringLength(500)]
        public string Comentario { get; set; }
    }
}
