using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CAUSA_CANCELACION")]
    public partial class CCausaCancelacion
    {
        [Column("ID_CAUSA_CANCELACION")]
        public int IdCausaCancelacion { get; set; }
        [Column("DESC_CAUSA_CANCELACION")]
        [StringLength(255)]
        public string DescCausaCancelacion { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_TIPO_CANCELADO")]
        public int? IdTipoCancelado { get; set; }
    }
}
