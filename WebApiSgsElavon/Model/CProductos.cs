using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_PRODUCTOS")]
    public partial class CProductos
    {
        public CProductos()
        {
            BdModeloModulo = new HashSet<BdModeloModulo>();
            CMarcas = new HashSet<CMarcas>();
        }

        [Key]
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }
        [Column("ID_TIPO_PRODUCTO")]
        public int? IdTipoProducto { get; set; }
        [Column("ID_PARENT")]
        public int? IdParent { get; set; }
        [Column("DESC_PRODUCTO")]
        [StringLength(50)]
        public string DescProducto { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("IMAGE")]
        [StringLength(50)]
        public string Image { get; set; }
        [Column("IMAGE_EDIT")]
        [StringLength(50)]
        public string ImageEdit { get; set; }
        [Column("IMAGE_INACTIVE")]
        [StringLength(50)]
        public string ImageInactive { get; set; }
        [Column("CLASS")]
        [StringLength(50)]
        public string Class { get; set; }
        [Column("CLASS_EDIT")]
        [StringLength(50)]
        public string ClassEdit { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("IS_GPRS")]
        public int? IsGprs { get; set; }
        [Column("IS_ACCESORIOS")]
        public int? IsAccesorios { get; set; }
        [Column("IS_INSUMOS")]
        public int? IsInsumos { get; set; }
        [Column("IS_KEY")]
        public int? IsKey { get; set; }
        [Column("IS_SOFTWARE")]
        public int? IsSoftware { get; set; }
        [Column("IS_BOM")]
        public int? IsBom { get; set; }
        [Column("IS_SPARE_PARTS")]
        public int? IsSpareParts { get; set; }

        [ForeignKey("IdTipoProducto")]
        [InverseProperty("CProductos")]
        public virtual CTipoProducto IdTipoProductoNavigation { get; set; }
        [InverseProperty("IdProductoModuloNavigation")]
        public virtual ICollection<BdModeloModulo> BdModeloModulo { get; set; }
        [InverseProperty("IdProductoNavigation")]
        public virtual ICollection<CMarcas> CMarcas { get; set; }
    }
}
