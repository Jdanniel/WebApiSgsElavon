using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_CLIENTE")]
    public partial class BdUsuarioCliente
    {
        [Key]
        [Column("ID_USUARIO_CLIENTE")]
        public int IdUsuarioCliente { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
