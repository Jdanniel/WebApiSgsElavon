using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PASO_AR_NUMBER")]
    public partial class BdPasoArNumber
    {
        [Column("ID_PASO")]
        public int IdPaso { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_STATUS")]
        public int? IdStatus { get; set; }
        [Column("NUMBER")]
        public int? Number { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
    }
}
