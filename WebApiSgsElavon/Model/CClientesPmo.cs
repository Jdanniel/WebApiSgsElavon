using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CLIENTES_PMO")]
    public partial class CClientesPmo
    {
        [Key]
        [Column("ID_CLIENTE_PRODUCTO")]
        public int IdClienteProducto { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
