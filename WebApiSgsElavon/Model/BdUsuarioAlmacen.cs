using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_USUARIO_ALMACEN")]
    public partial class BdUsuarioAlmacen
    {
        [Key]
        [Column("ID_USUARIO_ALMACEN")]
        public int IdUsuarioAlmacen { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_ALMACEN")]
        public int? IdAlmacen { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
