using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES_NO_REPORTADAS")]
    public partial class BdUnidadesNoReportadas
    {
        [Key]
        [Column("ID_UNIDAD_NO_REPORTADA")]
        public int IdUnidadNoReportada { get; set; }
        [Column("ID_AUDITORIA_REPORTE")]
        public int IdAuditoriaReporte { get; set; }
        [Column("NO_SERIE_NO_REPORTADO")]
        [StringLength(50)]
        public string NoSerieNoReportado { get; set; }
        [Column("ID_STATUS_SERIE")]
        public int? IdStatusSerie { get; set; }

        [ForeignKey("IdAuditoriaReporte")]
        [InverseProperty("BdUnidadesNoReportadas")]
        public virtual BdAuditoriaReporte IdAuditoriaReporteNavigation { get; set; }
    }
}
