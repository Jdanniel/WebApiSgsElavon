using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdOrdenCompraVendedor
{
    public int IdOrdenCompraVendedor { get; set; }

    public int? IdOrdenCompra { get; set; }

    public int? IdVendedor { get; set; }

    public int? ArcherVendorId { get; set; }

    public string Moneda { get; set; }

    public string TerminoPago { get; set; }

    public string NoOrdenCompra { get; set; }

    public string CentroCosto { get; set; }

    public string Comentario { get; set; }

    public int? IdTipoItemOrdenCompra { get; set; }
}
