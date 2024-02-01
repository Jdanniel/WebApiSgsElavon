using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCostoViaticosVistum
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? IdCliente { get; set; }

    public int? IdRegion { get; set; }

    public int IdConcepto { get; set; }

    public string Tipo { get; set; }

    public decimal? Costo { get; set; }
}
