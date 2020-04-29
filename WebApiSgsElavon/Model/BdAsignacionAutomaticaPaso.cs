using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ASIGNACION_AUTOMATICA_PASO")]
    public partial class BdAsignacionAutomaticaPaso
    {
        [Column("ID_ASIGNACION_AUTOMATICA_PASO")]
        public int IdAsignacionAutomaticaPaso { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
        [Column("ID_REGION")]
        public int? IdRegion { get; set; }
        [Column("ID_ZONA")]
        public int? IdZona { get; set; }
        [Column("ID_TECNICO")]
        public int? IdTecnico { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("CP")]
        [StringLength(50)]
        public string Cp { get; set; }
        [Column("IS_PROCESADA")]
        public int? IsProcesada { get; set; }
        [Column("MENSAJE")]
        [StringLength(255)]
        public string Mensaje { get; set; }
    }
}
