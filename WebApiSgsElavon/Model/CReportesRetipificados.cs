using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_REPORTES_RETIPIFICADOS")]
    public partial class CReportesRetipificados
    {
        [Key]
        [Column("ID_REPORTE_RETIPIFICADOS")]
        public int IdReporteRetipificados { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("DESC_REPORTE_RETIPIFICADOS")]
        [StringLength(50)]
        public string DescReporteRetipificados { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
