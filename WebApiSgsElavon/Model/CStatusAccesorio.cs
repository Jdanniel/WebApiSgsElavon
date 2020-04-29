using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_ACCESORIO")]
    public partial class CStatusAccesorio
    {
        public CStatusAccesorio()
        {
            BdUnidadAccesorio = new HashSet<BdUnidadAccesorio>();
        }

        [Key]
        [Column("ID_STATUS_ACCESORIO")]
        public int IdStatusAccesorio { get; set; }
        [Column("DESC_STATUS_ACCESORIO")]
        [StringLength(50)]
        public string DescStatusAccesorio { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdStatusAccesorioNavigation")]
        public virtual ICollection<BdUnidadAccesorio> BdUnidadAccesorio { get; set; }
    }
}
