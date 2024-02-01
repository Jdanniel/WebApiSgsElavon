using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdControlAccesoriosEntradum
{
    public int IdControlAccesoriosEntrada { get; set; }

    public int? IdTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdAccesorio { get; set; }

    public int? IdTipoMovAccesorio { get; set; }

    public int? Total { get; set; }

    public int? IdOrdenCompraAccesorios { get; set; }
}
