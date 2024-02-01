using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraOtrosCliente
{
    public int IdBitacoraOtrosClientes { get; set; }

    public int? IdOtrosClientes { get; set; }

    public string DescOtrosClientesAnterior { get; set; }

    public string DescOtrosClientesActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
