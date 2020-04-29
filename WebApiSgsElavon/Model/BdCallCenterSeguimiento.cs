using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CALL_CENTER_SEGUIMIENTO")]
    public partial class BdCallCenterSeguimiento
    {
        [Key]
        [Column("ID_CALL_CENTER")]
        public int IdCallCenter { get; set; }
        [Column("ID_AGENTE")]
        public int? IdAgente { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("CONTACTO")]
        [StringLength(80)]
        public string Contacto { get; set; }
        [Column("EXITO")]
        public int? Exito { get; set; }
        [Column("ID_MOTIVO_NO_CONTACTO")]
        public int? IdMotivoNoContacto { get; set; }
        [Column("INTENTO")]
        public int? Intento { get; set; }
        [Column("ID_MOTIVO_RECHAZO")]
        public int? IdMotivoRechazo { get; set; }
        [Column("ACEPTA_SERVICIO")]
        [StringLength(2)]
        public string AceptaServicio { get; set; }
    }
}
