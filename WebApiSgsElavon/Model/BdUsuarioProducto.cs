using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_PRODUCTO")]
    public partial class BdUsuarioProducto
    {
        [Key]
        [Column("ID_USUARIO_PRODUCTO")]
        public int IdUsuarioProducto { get; set; }
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
