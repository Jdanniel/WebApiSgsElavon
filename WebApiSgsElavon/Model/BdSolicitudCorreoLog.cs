using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOLICITUD_CORREO_LOG")]
    public partial class BdSolicitudCorreoLog
    {
        [Column("ID_SOLICITUD_CORREO_LOG")]
        public int IdSolicitudCorreoLog { get; set; }
        [Column("ID_CORREO")]
        [StringLength(100)]
        public string IdCorreo { get; set; }
        [Column("FECHA_CORREO", TypeName = "datetime")]
        public DateTime? FechaCorreo { get; set; }
        [Column("CONTENIDO_EMAIL")]
        public string ContenidoEmail { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("MENSAJE")]
        [StringLength(300)]
        public string Mensaje { get; set; }
    }
}
