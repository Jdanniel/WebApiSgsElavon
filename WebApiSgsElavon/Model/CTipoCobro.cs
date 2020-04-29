using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_COBRO")]
    public partial class CTipoCobro
    {
        public CTipoCobro()
        {
            BdArVisitas = new HashSet<BdArVisitas>();
            BdTipoServicioProducto = new HashSet<BdTipoServicioProducto>();
        }

        [Key]
        [Column("ID_TIPO_COBRO")]
        public int IdTipoCobro { get; set; }
        [Column("DESC_TIPO_COBRO")]
        [StringLength(50)]
        public string DescTipoCobro { get; set; }
        [Column("IS_COBRABLE")]
        public int? IsCobrable { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoCobroNavigation")]
        public virtual ICollection<BdArVisitas> BdArVisitas { get; set; }
        [InverseProperty("IdTipoCobroNavigation")]
        public virtual ICollection<BdTipoServicioProducto> BdTipoServicioProducto { get; set; }
    }
}
