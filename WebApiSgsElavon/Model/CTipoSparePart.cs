using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_SPARE_PART")]
    public partial class CTipoSparePart
    {
        public CTipoSparePart()
        {
            CSpareParts = new HashSet<CSpareParts>();
        }

        [Key]
        [Column("ID_TIPO_SPARE_PART")]
        public int IdTipoSparePart { get; set; }
        [Column("DESC_TIPO_SPARE_PART")]
        [StringLength(50)]
        public string DescTipoSparePart { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoSparePartNavigation")]
        public virtual ICollection<CSpareParts> CSpareParts { get; set; }
    }
}
