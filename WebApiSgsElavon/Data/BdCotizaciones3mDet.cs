using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCotizaciones3mDet
{
    public int IdDetCotizacion { get; set; }

    public int? IdInsumo { get; set; }

    public int? Cantidad { get; set; }

    public double? Precio { get; set; }

    public int? IdUm { get; set; }

    public double? Descuento { get; set; }

    public int? IdCotizacion { get; set; }

    public double? Total { get; set; }
}
