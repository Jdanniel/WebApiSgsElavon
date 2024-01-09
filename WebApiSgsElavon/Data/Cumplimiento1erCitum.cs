using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Cumplimiento1erCitum
{
    public int IdAr { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public int? IdProducto { get; set; }

    public string DescProducto { get; set; }

    public int IdCliente { get; set; }

    public string DescCliente { get; set; }

    public int? IdTipoServicio { get; set; }

    public string DescTipoServicio { get; set; }

    public int? IdRegion { get; set; }

    public string DescRegion { get; set; }

    public int? IdZona { get; set; }

    public string DescZona { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? Cargado { get; set; }

    public DateTime? PorAsignar { get; set; }

    public DateTime? Asignado { get; set; }

    public DateTime? EnSitio { get; set; }

    public int TiempoPorAsignar { get; set; }

    public int TiempoAsignado { get; set; }

    public int TiempoEnSitio { get; set; }
}
