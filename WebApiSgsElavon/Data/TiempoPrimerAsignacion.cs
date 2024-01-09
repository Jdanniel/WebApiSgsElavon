using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TiempoPrimerAsignacion
{
    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public string DescRegion { get; set; }

    public string DescZona { get; set; }

    public string NoAr { get; set; }

    public string DescProducto { get; set; }

    public string DescCliente { get; set; }

    public string DescTipoServicio { get; set; }

    public DateTime? FechaPorAsignar { get; set; }

    public DateTime? FechaAsignadoPorConfirmar { get; set; }

    public int TiempoPrimeraAsignación { get; set; }
}
