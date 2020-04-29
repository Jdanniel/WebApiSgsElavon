using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CLIENTE_MODELO")]
    public partial class BdClienteModelo
    {
        [Key]
        [Column("ID_CLIENTE_MODELO")]
        public int IdClienteModelo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("ID_MODELO")]
        public int? IdModelo { get; set; }
        [Column("IS_F11")]
        public int? IsF11 { get; set; }
        [Column("ID_ORDEN")]
        public int? IdOrden { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
