using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_WINCOR_CLIENTES")]
    public partial class BdWincorClientes
    {
        [Key]
        [Column("ID_CLIENTE_WINCOR")]
        public int IdClienteWincor { get; set; }
        [Column("NOMBRE")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
    }
}
