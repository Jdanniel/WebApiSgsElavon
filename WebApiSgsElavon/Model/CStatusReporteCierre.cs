using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_REPORTE_CIERRE")]
    public partial class CStatusReporteCierre
    {
        public CStatusReporteCierre()
        {
            BdReporteCierre = new HashSet<BdReporteCierre>();
        }

        [Key]
        [Column("ID_STATUS_REPORTE_CIERRE")]
        public int IdStatusReporteCierre { get; set; }
        [Column("DESC_STATUS_REPORTE_CIERRE")]
        [StringLength(50)]
        public string DescStatusReporteCierre { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdStatusReporteCierreNavigation")]
        public virtual ICollection<BdReporteCierre> BdReporteCierre { get; set; }
    }
}
