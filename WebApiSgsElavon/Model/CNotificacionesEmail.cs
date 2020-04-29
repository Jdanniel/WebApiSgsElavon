using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_NOTIFICACIONES_EMAIL")]
    public partial class CNotificacionesEmail
    {
        [Column("ID_NOTIFICACIONES_EMAIL")]
        public int IdNotificacionesEmail { get; set; }
        [Column("DESC_NOTIFICACION")]
        public string DescNotificacion { get; set; }
        [Column("VALOR")]
        public string Valor { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
