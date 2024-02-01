using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAuditoriaReporte
{
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

    public virtual ICollection<BdUnidadesNoReportada> BdUnidadesNoReportada { get; set; } = new List<BdUnidadesNoReportada>();

    public virtual ICollection<BdUnidadesReportada> BdUnidadesReportada { get; set; } = new List<BdUnidadesReportada>();

    public virtual CTipoInventario IdTipoInventarioNavigation { get; set; }
}
