using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MOV_INV")]
    public partial class CMovInv
    {
        public CMovInv()
        {
            BdServicioMovInv = new HashSet<BdServicioMovInv>();
        }

        [Key]
        [Column("ID_MOV_INV")]
        public int IdMovInv { get; set; }
        [Column("DESC_MOV_INV")]
        [StringLength(50)]
        public string DescMovInv { get; set; }
        [Column("CORTO")]
        [StringLength(20)]
        public string Corto { get; set; }
        [Column("HREF")]
        [StringLength(20)]
        public string Href { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("IS_OBLIGATORIO")]
        public int? IsObligatorio { get; set; }

        [InverseProperty("IdMovInvNavigation")]
        public virtual ICollection<BdServicioMovInv> BdServicioMovInv { get; set; }
    }
}
