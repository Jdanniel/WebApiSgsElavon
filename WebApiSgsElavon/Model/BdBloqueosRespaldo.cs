using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BLOQUEOS_RESPALDO")]
    public partial class BdBloqueosRespaldo
    {
        [Column("ID_BLOQUEO_RESPALDO")]
        public int IdBloqueoRespaldo { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("NO_AFILIACION")]
        public string NoAfiliacion { get; set; }
        [Column("CP")]
        public string Cp { get; set; }
        [Column("PROVEEDOR")]
        public string Proveedor { get; set; }
        [Column("TERRITORIO")]
        public string Territorio { get; set; }
        [Column("TOTAL_ROLLOS")]
        public int? TotalRollos { get; set; }
        [Column("BLOQUEO")]
        public int? Bloqueo { get; set; }
        [Column("MENSAJE")]
        public string Mensaje { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
    }
}
