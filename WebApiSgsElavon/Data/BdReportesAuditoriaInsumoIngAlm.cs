using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReportesAuditoriaInsumoIngAlm
{
    public int IdReporteAuditoriaInsumoIngAlm { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCliente { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidad { get; set; }

    public int? IdResponsableInventario { get; set; }

    public int? IdAuditoria { get; set; }
}
