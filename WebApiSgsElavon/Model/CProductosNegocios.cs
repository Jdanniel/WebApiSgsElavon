using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PRODUCTOS_NEGOCIOS")]
    public partial class CProductosNegocios
    {
        [Column("ID_PRODUCTO_NEGOCIO")]
        public int IdProductoNegocio { get; set; }
        [Column("DESC_PRODUCTO_NEGOCIO")]
        public string DescProductoNegocio { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
    }
}
