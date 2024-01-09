using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ProvisionIngresoRegionProd
{
    public int Id { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string Region { get; set; }

    public string Producto { get; set; }

    public double? Ingreso { get; set; }
}
