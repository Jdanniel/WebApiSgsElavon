using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_TRANSACCIONES")]
    public partial class BdTransacciones
    {
        [Key]
        [Column("ID_TRANSACCIONES")]
        public int IdTransacciones { get; set; }
        [Column("MONTH")]
        public int Month { get; set; }
        [Column("YEAR")]
        public int Year { get; set; }
        [Column("NO_FILIACION")]
        public int NoFiliacion { get; set; }
        [Column("APPROVEDC_COUNT")]
        public int ApprovedcCount { get; set; }
        [Column("DECLINEDCOUNT")]
        public int Declinedcount { get; set; }
    }
}
