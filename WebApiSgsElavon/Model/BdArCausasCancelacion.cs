using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_CAUSAS_CANCELACION")]
    public partial class BdArCausasCancelacion
    {
        [Column("ID_AR_CAUSA_CANCELACION")]
        public int IdArCausaCancelacion { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("ID_CAUSA_CANCELACION")]
        public int? IdCausaCancelacion { get; set; }
    }
}
