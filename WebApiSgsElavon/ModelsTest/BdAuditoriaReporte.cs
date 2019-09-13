using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdAuditoriaReporte
    {
        public BdAuditoriaReporte()
        {
            BdUnidadesNoReportadas = new HashSet<BdUnidadesNoReportadas>();
            BdUnidadesReportadas = new HashSet<BdUnidadesReportadas>();
        }

        public int IdAuditoriaReporte { get; set; }
        public int? IdAuditoria { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdArchivoAttach { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Status { get; set; }
        public int? IdTipoInventario { get; set; }
        public int? ItemsEnSistema { get; set; }
        public double? Efectividad { get; set; }
        public string Reporte { get; set; }
        public int? IdResponsableInventario { get; set; }

        public virtual BdAuditorias IdAuditoriaNavigation { get; set; }
        public virtual CTipoInventario IdTipoInventarioNavigation { get; set; }
        public virtual ICollection<BdUnidadesNoReportadas> BdUnidadesNoReportadas { get; set; }
        public virtual ICollection<BdUnidadesReportadas> BdUnidadesReportadas { get; set; }
    }
}
