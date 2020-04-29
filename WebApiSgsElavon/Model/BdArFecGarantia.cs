using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_FEC_GARANTIA")]
    public partial class BdArFecGarantia
    {
        [Column("ID_AR_FEC_GARANTIA")]
        public int IdArFecGarantia { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ERROR")]
        [StringLength(250)]
        public string Error { get; set; }
    }
}
