using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ACCESORIOS")]
    public partial class CAccesorios
    {
        public CAccesorios()
        {
            BdModeloAccesorio = new HashSet<BdModeloAccesorio>();
            BdUnidadAccesorio = new HashSet<BdUnidadAccesorio>();
        }

        [Key]
        [Column("ID_ACCESORIO")]
        public int IdAccesorio { get; set; }
        [Column("DESC_ACCESORIO")]
        [StringLength(50)]
        public string DescAccesorio { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 0)")]
        public decimal? Costo { get; set; }
        [Column("ID_PRODUCTO")]
        public int? IdProducto { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }

        [InverseProperty("IdAccesorioNavigation")]
        public virtual ICollection<BdModeloAccesorio> BdModeloAccesorio { get; set; }
        [InverseProperty("IdAccesorioNavigation")]
        public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
    }
}
