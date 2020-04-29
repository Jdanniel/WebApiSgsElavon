using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_SERVICIO")]
    public partial class CTipoServicio
    {
        public CTipoServicio()
        {
            BdTipoServicioProducto = new HashSet<BdTipoServicioProducto>();
            CServicios = new HashSet<CServicios>();
        }

        [Key]
        [Column("ID_TIPO_SERVICIO")]
        public int IdTipoServicio { get; set; }
        [Required]
        [Column("DESC_TIPO_SERVICIO")]
        [StringLength(50)]
        public string DescTipoServicio { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoServicioNavigation")]
        public virtual ICollection<BdTipoServicioProducto> BdTipoServicioProducto { get; set; }
        [InverseProperty("IdTipoServicioNavigation")]
        public virtual ICollection<CServicios> CServicios { get; set; }
    }
}
