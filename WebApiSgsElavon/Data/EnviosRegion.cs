using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class EnviosRegion
{
    public int Id { get; set; }

    public string Region { get; set; }

    public DateOnly? Fecha { get; set; }

    public double? Importe { get; set; }

    public string Proveedor { get; set; }
}
