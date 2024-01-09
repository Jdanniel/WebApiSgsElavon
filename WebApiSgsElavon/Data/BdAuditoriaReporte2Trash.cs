using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdAuditoriaReporte2Trash
{
    public int IdAuditoriaReporte { get; set; }

    public int? IdAuditoria { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }

    public int? IdTipoInventario { get; set; }

    public int? ItemsEnSistema { get; set; }

    public int? ItemsReportados { get; set; }

    public decimal? Efectividad { get; set; }

    public int? IdResponsableInventario { get; set; }

    public int? IdUsuarioQueElimino { get; set; }

    public DateTime? FechaEnLaQueSeElimino { get; set; }
}
