using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class GasolinaAvion
{
    public int Id { get; set; }

    public string DescCliente { get; set; }

    public string DescViatico { get; set; }

    public double? Importe { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public string Curp { get; set; }
}
