using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdIngreso
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Secuencia { get; set; }

    public int? IdRegion { get; set; }

    public string Plaza { get; set; }

    public string Cliente { get; set; }

    public string Producto { get; set; }

    public string Proyecto { get; set; }

    public string TipoIngreso { get; set; }

    public string Afiliacion { get; set; }

    public string Moneda { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Tc { get; set; }

    public decimal? TotalPesos { get; set; }
}
