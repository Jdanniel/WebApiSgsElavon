using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ALTA_FEC_GARANTIA")]
    public partial class BdAltaFecGarantia
    {
        [Column("ID_ALTA")]
        public int IdAlta { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("FECHA", TypeName = "date")]
        public DateTime? Fecha { get; set; }
        [Column("HORA")]
        public TimeSpan? Hora { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ERROR")]
        [StringLength(250)]
        public string Error { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
    }
}
