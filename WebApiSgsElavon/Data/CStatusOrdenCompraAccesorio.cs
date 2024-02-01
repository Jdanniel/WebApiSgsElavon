using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusOrdenCompraAccesorio
{
    public int IdStatusOrdenCompraAccesorio { get; set; }

    public string StatusAccesorio { get; set; }

    public int? IdUsuario { get; set; }

    public string Tipo { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
