using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("TEMP_HORARIOS")]
    public partial class TempHorarios
    {
        [Key]
        [Column("ID_HORARIOS")]
        public int IdHorarios { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(50)]
        public string NoAfiliacion { get; set; }
        [Column("ID_HORARIO_ACCESO")]
        public int? IdHorarioAcceso { get; set; }
        [Column("ID_HORARIO_UPTIME")]
        public int? IdHorarioUptime { get; set; }
    }
}
