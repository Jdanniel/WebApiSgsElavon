using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_TIPO_DOWNTIME_TRIGGER")]
    public partial class CTipoDowntimeTrigger
    {
        public CTipoDowntimeTrigger()
        {
            CStatusAr = new HashSet<CStatusAr>();
        }

        [Key]
        [Column("ID_TIPO_DOWNTIME_TRIGGER")]
        public int IdTipoDowntimeTrigger { get; set; }
        [Column("DESC_TIPO_DOWNTIME_TRIGGER")]
        [StringLength(50)]
        public string DescTipoDowntimeTrigger { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdTipoDowntimeTriggerNavigation")]
        public virtual ICollection<CStatusAr> CStatusAr { get; set; }
    }
}
