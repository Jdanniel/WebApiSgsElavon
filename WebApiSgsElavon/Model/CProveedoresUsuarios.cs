using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PROVEEDORES_USUARIOS")]
    public partial class CProveedoresUsuarios
    {
        [Column("ID_PROVEEDOR_USUARIO")]
        public int IdProveedorUsuario { get; set; }
        [Column("DESC_PROVEEDOR_USUARIO")]
        [StringLength(255)]
        public string DescProveedorUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string Status { get; set; }
    }
}
