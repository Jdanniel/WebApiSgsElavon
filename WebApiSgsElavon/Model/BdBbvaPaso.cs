using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BBVA_PASO")]
    public partial class BdBbvaPaso
    {
        [Column("ID_BBVA_PASO")]
        public int IdBbvaPaso { get; set; }
        [Column("BODY")]
        public string Body { get; set; }
        [Column("FROM")]
        [StringLength(250)]
        public string From { get; set; }
        [Column("SUBJECT")]
        [StringLength(250)]
        public string Subject { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime FecAlta { get; set; }
        [Column("NUMBER_MSG")]
        public int? NumberMsg { get; set; }
    }
}
