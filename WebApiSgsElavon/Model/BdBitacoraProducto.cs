using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_PRODUCTO")]
    public partial class BdBitacoraProducto
    {
        [Column("ID_BITACORA_PRODUCTO")]
        public int IdBitacoraProducto { get; set; }
        [Column("DESC_PRODUCTO")]
        [StringLength(255)]
        public string DescProducto { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("IS_UPDATE")]
        public int? IsUpdate { get; set; }
    }
}
