using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioNoInventario
{
    public int IdBitacoraCambioNoInventario { get; set; }

    public int? IdCarga { get; set; }

    public string Serie { get; set; }

    public string NoInventario { get; set; }

    public int? IdUsuario { get; set; }
}
