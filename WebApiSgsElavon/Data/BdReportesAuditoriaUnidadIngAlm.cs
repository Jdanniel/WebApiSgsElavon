using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReportesAuditoriaUnidadIngAlm
{
    public int IdReporteAuditoriaUnidadIngAlm { get; set; }

    public string NoSerie { get; set; }

    public int? IdProducto { get; set; }

    public int? IdCliente { get; set; }

    public int? IdModelo { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IdResponsableInventario { get; set; }

    public int? IdAuditoria { get; set; }

    public long? NoSim { get; set; }
}
