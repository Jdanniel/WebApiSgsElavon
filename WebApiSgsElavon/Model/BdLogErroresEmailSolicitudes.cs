using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_LOG_ERRORES_EMAIL_SOLICITUDES")]
    public partial class BdLogErroresEmailSolicitudes
    {
        [Column("ID_LOG_ERROR_EMAIL")]
        public int IdLogErrorEmail { get; set; }
        [Column("DESCRIPCION_ERROR")]
        [StringLength(1500)]
        public string DescripcionError { get; set; }
        [Column("MODULO")]
        [StringLength(200)]
        public string Modulo { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
    }
}
