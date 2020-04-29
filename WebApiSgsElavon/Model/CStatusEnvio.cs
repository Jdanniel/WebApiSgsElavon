using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_ENVIO")]
    public partial class CStatusEnvio
    {
        public CStatusEnvio()
        {
            BdEnvios = new HashSet<BdEnvios>();
        }

        [Key]
        [Column("ID_STATUS_ENVIO")]
        public int IdStatusEnvio { get; set; }
        [Column("DESC_STATUS_ENVIO")]
        [StringLength(50)]
        public string DescStatusEnvio { get; set; }
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }

        [InverseProperty("IdStatusEnvioNavigation")]
        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
    }
}
