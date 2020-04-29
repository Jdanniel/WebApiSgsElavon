using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CP_ASIGNACION_AUTOMATICA")]
    public partial class BdCpAsignacionAutomatica
    {
        [Column("ID_CP_ASIGNACION_AUTOMATICA")]
        public int IdCpAsignacionAutomatica { get; set; }
        [Column("ID_REGLA_ASIGNACION_AUTOMATICA")]
        public int? IdReglaAsignacionAutomatica { get; set; }
        [Column("CP")]
        [StringLength(10)]
        public string Cp { get; set; }
    }
}
