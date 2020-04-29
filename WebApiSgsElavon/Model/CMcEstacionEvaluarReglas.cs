using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_ESTACION_EVALUAR_REGLAS")]
    public partial class CMcEstacionEvaluarReglas
    {
        [Column("ID_ESTACION_EVALUAR_REGLAS")]
        public int IdEstacionEvaluarReglas { get; set; }
        [Column("DESCRIPCION_ESTACION_REGLAS")]
        [StringLength(200)]
        public string DescripcionEstacionReglas { get; set; }
        [Column("MIN_TIEMPO")]
        public int? MinTiempo { get; set; }
        [Column("MAX_TIEMPO")]
        public int? MaxTiempo { get; set; }
        [Column("DANADO_MIN_TIEMPO")]
        public int? DanadoMinTiempo { get; set; }
        [Column("DANADO_MAX_TIEMPO")]
        public int? DanadoMaxTiempo { get; set; }
        [Column("ID_STATUS_UNIDAD")]
        public int? IdStatusUnidad { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("ID_ESTACION_EVALUAR")]
        public int? IdEstacionEvaluar { get; set; }
        [Column("REGLA")]
        [StringLength(200)]
        public string Regla { get; set; }
    }
}
