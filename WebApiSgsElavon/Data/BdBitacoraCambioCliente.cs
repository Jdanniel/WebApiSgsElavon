using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioCliente
{
    public int IdBitacoraCambioCliente { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdClientesInicial { get; set; }

    public int? IdClienteFinal { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? Fecha { get; set; }
}
