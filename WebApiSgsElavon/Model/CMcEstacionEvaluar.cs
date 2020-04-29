using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_ESTACION_EVALUAR")]
    public partial class CMcEstacionEvaluar
    {
        [Column("ID_ESTACION_EVALUAR")]
        public int IdEstacionEvaluar { get; set; }
        [Column("DESCRIPCION_ESTACION")]
        [StringLength(200)]
        public string DescripcionEstacion { get; set; }
    }
}
