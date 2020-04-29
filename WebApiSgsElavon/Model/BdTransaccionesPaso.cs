using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TRANSACCIONES_PASO")]
    public partial class BdTransaccionesPaso
    {
        [Key]
        [Column("ID_TRANSACCIONES_PASO")]
        public int IdTransaccionesPaso { get; set; }
        [Column("ID_CARGA")]
        public int IdCarga { get; set; }
        [Column("MONTH")]
        public int Month { get; set; }
        [Column("YEAR")]
        public int Year { get; set; }
        [Column("NO_AFILIACION")]
        public int NoAfiliacion { get; set; }
        [Column("APPROVEDC_COUNT")]
        public int ApprovedcCount { get; set; }
        [Column("DECLINEDCOUNT")]
        public int Declinedcount { get; set; }
        [Column("IS_ERROR")]
        public int? IsError { get; set; }
        [Column("DESC_ERROR")]
        [StringLength(255)]
        public string DescError { get; set; }
    }
}
