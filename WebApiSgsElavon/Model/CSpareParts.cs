using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_SPARE_PARTS")]
    public partial class CSpareParts
    {
        public CSpareParts()
        {
            BdArSparePart = new HashSet<BdArSparePart>();
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
            BdSolicitudesAlmacenOld = new HashSet<BdSolicitudesAlmacenOld>();
            BdSparePartPrecio = new HashSet<BdSparePartPrecio>();
        }

        [Key]
        [Column("ID_SPARE_PART")]
        public int IdSparePart { get; set; }
        [Column("DESC_SPARE_PART")]
        [StringLength(50)]
        public string DescSparePart { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        [Column("ID_MARCA")]
        public int? IdMarca { get; set; }
        [Column("ID_TIPO_SPARE_PART")]
        public int? IdTipoSparePart { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column("ID_ATTACH_IMAGEN_SPARE_PART")]
        public int? IdAttachImagenSparePart { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [ForeignKey("IdTipoSparePart")]
        [InverseProperty("CSpareParts")]
        public virtual CTipoSparePart IdTipoSparePartNavigation { get; set; }
        [InverseProperty("IdSparePartNavigation")]
        public virtual ICollection<BdArSparePart> BdArSparePart { get; set; }
        [InverseProperty("IdSparePartNavigation")]
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
        [InverseProperty("IdSparePartNavigation")]
        public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOld { get; set; }
        [InverseProperty("IdSparePartNavigation")]
        public virtual ICollection<BdSparePartPrecio> BdSparePartPrecio { get; set; }
    }
}
