using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Reincidente
{
    public int? IdProducto { get; set; }

    public string DescProducto { get; set; }

    public int IdCliente { get; set; }

    public string DescCliente { get; set; }

    public int? IdNegocio { get; set; }

    public string DescNegocio { get; set; }

    public string NoAfiliacion { get; set; }

    public int? Tickets { get; set; }

    public int? Visitas { get; set; }

    public decimal Viaticos { get; set; }
}
