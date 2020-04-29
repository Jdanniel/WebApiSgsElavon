using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_DIAGNOSTICO")]
    public partial class BdBitacoraDiagnostico
    {
        [Column("ID_BITACORA_DIAGNOSTICO")]
        public int IdBitacoraDiagnostico { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("ID_NIVEL_DIAGNOSTICO")]
        public int? IdNivelDiagnostico { get; set; }
        [Column("ID_TECNICO_CAMBIO")]
        public int? IdTecnicoCambio { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
    }
}
