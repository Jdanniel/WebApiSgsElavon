using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_URGENCIA_ENVIO")]
    public partial class CUrgenciaEnvio
    {
        public CUrgenciaEnvio()
        {
            BdEnvios = new HashSet<BdEnvios>();
        }

        [Key]
        [Column("ID_URGENCIA_ENVIO")]
        public int IdUrgenciaEnvio { get; set; }
        [Column("DESC_URGENCIA_ENVIO")]
        [StringLength(50)]
        public string DescUrgenciaEnvio { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdUrgenciaEnvioNavigation")]
        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
    }
}
