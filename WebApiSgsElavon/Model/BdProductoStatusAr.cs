using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_PRODUCTO_STATUS_AR")]
    public partial class BdProductoStatusAr
    {
        public BdProductoStatusAr()
        {
            BdClienteProductoStatusAr = new HashSet<BdClienteProductoStatusAr>();
        }

        [Key]
        [Column("ID_PRODUCTO_STATUS_AR")]
        public int IdProductoStatusAr { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("ID_STATUS_AR")]
        public int? IdStatusAr { get; set; }
        [Column("STATUS_WEB")]
        [StringLength(10)]
        public string StatusWeb { get; set; }
        [Column("STATUS_BB")]
        [StringLength(10)]
        public string StatusBb { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdStatusAr")]
        [InverseProperty("BdProductoStatusAr")]
        public virtual CStatusAr IdStatusArNavigation { get; set; }
        [InverseProperty("IdProductoStatusArNavigation")]
        public virtual ICollection<BdClienteProductoStatusAr> BdClienteProductoStatusAr { get; set; }
    }
}
