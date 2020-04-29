using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_GASTOS_OPERACION")]
    public partial class BdGastosOperacion
    {
        [Key]
        [Column("ID_GASTOS_OP")]
        public int IdGastosOp { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("IMPORTE", TypeName = "decimal(18, 2)")]
        public decimal? Importe { get; set; }
    }
}
