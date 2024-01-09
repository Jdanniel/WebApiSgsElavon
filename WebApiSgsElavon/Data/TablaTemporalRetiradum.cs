using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TablaTemporalRetiradum
{
    public DateTime? FechaEntregaFisica { get; set; }

    public DateTime FecActualizacion { get; set; }

    public string EstatusEnCie { get; set; }

    public string Plaza { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public string NoSerie { get; set; }

    public string Remesa { get; set; }

    public string NoAr { get; set; }

    public string ProveedorRecive { get; set; }

    public string Tecnico { get; set; }

    public string Observaciones { get; set; }
}
