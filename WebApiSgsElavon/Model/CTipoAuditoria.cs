using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_AUDITORIA")]
    public partial class CTipoAuditoria
    {
        public CTipoAuditoria()
        {
            BdAuditorias = new HashSet<BdAuditorias>();
        }

        [Key]
        [Column("ID_TIPO_AUDITORIA")]
        public int IdTipoAuditoria { get; set; }
        [Column("DESC_TIPO_AUDITORIA")]
        [StringLength(255)]
        public string DescTipoAuditoria { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }

        [InverseProperty("IdTipoAuditoriaNavigation")]
        public virtual ICollection<BdAuditorias> BdAuditorias { get; set; }
    }
}
