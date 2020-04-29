using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REPORTE_CIERRE")]
    public partial class BdReporteCierre
    {
        public BdReporteCierre()
        {
            BdReporteCierreAr = new HashSet<BdReporteCierreAr>();
        }

        [Column("ID_REPORTE_CIERRE")]
        public int IdReporteCierre { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("REPORT")]
        [StringLength(4000)]
        public string Report { get; set; }
        [Column("NUM_ARS")]
        public int? NumArs { get; set; }
        [Column("ID_STATUS_REPORTE_CIERRE")]
        public int? IdStatusReporteCierre { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdReporteCierre")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdStatusReporteCierre")]
        [InverseProperty("BdReporteCierre")]
        public virtual CStatusReporteCierre IdStatusReporteCierreNavigation { get; set; }
        [InverseProperty("IdReporteCierreNavigation")]
        public virtual ICollection<BdReporteCierreAr> BdReporteCierreAr { get; set; }
    }
}
