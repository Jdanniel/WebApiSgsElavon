using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CReportesRetipificado
{
    public int IdReporteRetipificados { get; set; }

    public int? IdCliente { get; set; }

    public string DescReporteRetipificados { get; set; }

    public string Status { get; set; }
}
