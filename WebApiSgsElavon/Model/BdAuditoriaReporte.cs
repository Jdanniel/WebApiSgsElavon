using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AUDITORIA_REPORTE")]
    public partial class BdAuditoriaReporte
    {
        public BdAuditoriaReporte()
        {
            BdUnidadesNoReportadas = new HashSet<BdUnidadesNoReportadas>();
            BdUnidadesReportadas = new HashSet<BdUnidadesReportadas>();
        }

        [Key]
        [Column("ID_AUDITORIA_REPORTE")]
        public int IdAuditoriaReporte { get; set; }
        [Column("ID_AUDITORIA")]
        public int? IdAuditoria { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("ID_ARCHIVO_ATTACH")]
        public int? IdArchivoAttach { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_TIPO_INVENTARIO")]
        public int? IdTipoInventario { get; set; }
        [Column("ITEMS_EN_SISTEMA")]
        public int? ItemsEnSistema { get; set; }
        [Column("EFECTIVIDAD")]
        public double? Efectividad { get; set; }
        [Column("REPORTE")]
        [StringLength(50)]
        public string Reporte { get; set; }
        [Column("ID_RESPONSABLE_INVENTARIO")]
        public int? IdResponsableInventario { get; set; }

        [ForeignKey("IdAuditoria")]
        [InverseProperty("BdAuditoriaReporte")]
        public virtual BdAuditorias IdAuditoriaNavigation { get; set; }
        [ForeignKey("IdTipoInventario")]
        [InverseProperty("BdAuditoriaReporte")]
        public virtual CTipoInventario IdTipoInventarioNavigation { get; set; }
        [InverseProperty("IdAuditoriaReporteNavigation")]
        public virtual ICollection<BdUnidadesNoReportadas> BdUnidadesNoReportadas { get; set; }
        [InverseProperty("IdAuditoriaReporteNavigation")]
        public virtual ICollection<BdUnidadesReportadas> BdUnidadesReportadas { get; set; }
    }
}
