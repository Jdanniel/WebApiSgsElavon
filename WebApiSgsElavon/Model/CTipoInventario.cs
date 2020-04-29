using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_INVENTARIO")]
    public partial class CTipoInventario
    {
        public CTipoInventario()
        {
            BdAuditoriaReporte = new HashSet<BdAuditoriaReporte>();
        }

        [Key]
        [Column("ID_TIPO_INVENTARIO")]
        public int IdTipoInventario { get; set; }
        [Column("DESC_TIPO_INVENTARIO")]
        [StringLength(255)]
        public string DescTipoInventario { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTipoInventarioNavigation")]
        public virtual ICollection<BdAuditoriaReporte> BdAuditoriaReporte { get; set; }
    }
}
