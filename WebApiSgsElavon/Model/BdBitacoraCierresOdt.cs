using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_CIERRES_ODT")]
    public partial class BdBitacoraCierresOdt
    {
        [Column("ID_BITACORA_CIERRES_ODT")]
        public int IdBitacoraCierresOdt { get; set; }
        [Column("NO_AFILIACION")]
        public string NoAfiliacion { get; set; }
        [Column("TOTAL_ROLLOS_ANTERIOR")]
        public int? TotalRollosAnterior { get; set; }
        [Column("INSUMOS")]
        public int? Insumos { get; set; }
        [Column("TOTAL_ROLLOS_ACTUAL")]
        public int? TotalRollosActual { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
