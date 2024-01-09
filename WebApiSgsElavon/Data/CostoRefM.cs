using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CostoRefM
{
    public int Id { get; set; }

    public string Sku { get; set; }

    public string Descripcion { get; set; }

    public DateOnly? FechaUCompra { get; set; }

    public double? CostoUCompra { get; set; }
}
