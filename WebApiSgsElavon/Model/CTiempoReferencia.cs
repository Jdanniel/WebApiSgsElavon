using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIEMPO_REFERENCIA")]
    public partial class CTiempoReferencia
    {
        public CTiempoReferencia()
        {
            BdReglasStatusAr = new HashSet<BdReglasStatusAr>();
        }

        [Key]
        [Column("ID_TIEMPO_REFERENCIA")]
        public int IdTiempoReferencia { get; set; }
        [Required]
        [Column("DESC_TIEMPO_REFERENCIA")]
        [StringLength(50)]
        public string DescTiempoReferencia { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("FACTOR")]
        public int? Factor { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTiempoReferenciaNavigation")]
        public virtual ICollection<BdReglasStatusAr> BdReglasStatusAr { get; set; }
    }
}
