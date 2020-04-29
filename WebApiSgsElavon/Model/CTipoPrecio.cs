using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_PRECIO")]
    public partial class CTipoPrecio
    {
        public CTipoPrecio()
        {
            CServicios = new HashSet<CServicios>();
        }

        [Key]
        [Column("ID_TIPO_PRECIO")]
        public int IdTipoPrecio { get; set; }
        [Column("DESC_TIPO_PRECIO")]
        [StringLength(50)]
        public string DescTipoPrecio { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoPrecioNavigation")]
        public virtual ICollection<CServicios> CServicios { get; set; }
    }
}
