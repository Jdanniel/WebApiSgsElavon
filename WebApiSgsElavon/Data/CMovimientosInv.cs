using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CMovimientosInv
{
    public int IdMovInventario { get; set; }

    public string DescMovInventario { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
