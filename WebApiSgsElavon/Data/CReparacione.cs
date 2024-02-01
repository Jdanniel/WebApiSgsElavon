using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CReparacione
{
    public int IdReparacion { get; set; }

    public int IdCliente { get; set; }

    public string DescReparacion { get; set; }

    public decimal? Precio { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
