using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CLIENTE_WEEKHOUR")]
    public partial class BdClienteWeekhour
    {
        [Key]
        [Column("ID_CLIENTE_WEEKHOUR")]
        public int IdClienteWeekhour { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_WEEKHOUR")]
        public int? IdWeekhour { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
    }
}
