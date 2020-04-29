using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_LOG_WS")]
    public partial class BdArLogWs
    {
        [Column("ID_AR_LOG_WS")]
        public int IdArLogWs { get; set; }
        [Column("NO_AR")]
        [StringLength(255)]
        public string NoAr { get; set; }
        [Column("ESTATUS")]
        [StringLength(255)]
        public string Estatus { get; set; }
        [Column("ERROR")]
        public string Error { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
