using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REPORTE_CIERRE_AR")]
    public partial class BdReporteCierreAr
    {
        [Key]
        [Column("ID_REPORTE_CIERRE_AR")]
        public int IdReporteCierreAr { get; set; }
        [Column("ID_REPORTE_CIERRE")]
        public int IdReporteCierre { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdReporteCierreAr")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdReporteCierre")]
        [InverseProperty("BdReporteCierreAr")]
        public virtual BdReporteCierre IdReporteCierreNavigation { get; set; }
    }
}
