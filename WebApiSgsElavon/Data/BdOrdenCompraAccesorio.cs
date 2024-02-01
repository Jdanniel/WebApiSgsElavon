using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdOrdenCompraAccesorio
{
    public int IdOrdenCompraAccesorios { get; set; }

    public int? IdOrdenCompra { get; set; }

    public int? IdAccesorio { get; set; }

    public int? Cantidad { get; set; }

    public int? Costo { get; set; }

    public int? Total { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IsRecibido { get; set; }
}
