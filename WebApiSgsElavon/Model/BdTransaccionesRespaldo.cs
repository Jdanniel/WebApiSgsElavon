using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TRANSACCIONES_RESPALDO")]
    public partial class BdTransaccionesRespaldo
    {
        [Column("ID_TRANSACCION_RESPALDO")]
        public int IdTransaccionRespaldo { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("NO_AFILIACION")]
        public int? NoAfiliacion { get; set; }
        [Column("APPROVEDC_COUNT")]
        public int? ApprovedcCount { get; set; }
        [Column("DECLINEDCOUNT")]
        public int? Declinedcount { get; set; }
        [Column("FECHA", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
    }
}
