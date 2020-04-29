using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_SOFTEL_PASO")]
    public partial class BdSoftelPaso
    {
        [Column("ID_SOFTEL_PASO")]
        public int IdSoftelPaso { get; set; }
        [Column("BODY")]
        public string Body { get; set; }
        [Column("FROM")]
        [StringLength(255)]
        public string From { get; set; }
        [Column("SUBJECT")]
        [StringLength(255)]
        public string Subject { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("NUMBER_MSG")]
        public int? NumberMsg { get; set; }
    }
}
