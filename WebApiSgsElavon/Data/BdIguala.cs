using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdIguala
{
    public int IdIgualas { get; set; }

    public string NoAfiliacion { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    public decimal? Precio { get; set; }

    public int? IsDolar { get; set; }

    public string Status { get; set; }

    public int? IdCliente { get; set; }

    public decimal? PrecioDolar { get; set; }

    public decimal? TipoDeCambio { get; set; }
}
