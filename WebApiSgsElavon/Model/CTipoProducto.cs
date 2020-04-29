using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_PRODUCTO")]
    public partial class CTipoProducto
    {
        public CTipoProducto()
        {
            CProductos = new HashSet<CProductos>();
        }

        [Key]
        [Column("ID_TIPO_PRODUCTO")]
        public int IdTipoProducto { get; set; }
        [Column("DESC_TIPO_PRODUCTO")]
        [StringLength(50)]
        public string DescTipoProducto { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoProductoNavigation")]
        public virtual ICollection<CProductos> CProductos { get; set; }
    }
}
