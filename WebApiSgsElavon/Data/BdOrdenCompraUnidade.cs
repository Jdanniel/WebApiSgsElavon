using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdOrdenCompraUnidade
{
    public int IdOrdenCompraUnidad { get; set; }

    public int? IdOrdenCompra { get; set; }

    public int? IdModelo { get; set; }

    public double? Cantidad { get; set; }

    public double? Costo { get; set; }

    public double? Total { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IsRecibido { get; set; }
}
