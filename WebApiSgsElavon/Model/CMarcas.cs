using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MARCAS")]
    public partial class CMarcas
    {
        public CMarcas()
        {
            BdModeloModulo = new HashSet<BdModeloModulo>();
        }

        [Key]
        [Column("ID_MARCA")]
        public int IdMarca { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("DESC_MARCA")]
        [StringLength(50)]
        public string DescMarca { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_ACCESS")]
        public int? IdAccess { get; set; }

        [ForeignKey("IdProducto")]
        [InverseProperty("CMarcas")]
        public virtual CProductos IdProductoNavigation { get; set; }
        [InverseProperty("IdMarcaModuloNavigation")]
        public virtual ICollection<BdModeloModulo> BdModeloModulo { get; set; }
    }
}
