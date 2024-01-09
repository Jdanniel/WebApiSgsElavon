using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdIngresosVistum
{
    public string TipoIngreso { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? IdProyecto { get; set; }

    public int? IdRegion { get; set; }

    public int IdConcepto { get; set; }

    public string Tipo { get; set; }

    public decimal? TotalPesos { get; set; }
}
