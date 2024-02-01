using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraRfcCliente
{
    public int IdBitacoraRfcClientes { get; set; }

    public string Rfc { get; set; }

    public string NoAfiliacion { get; set; }

    public string ClienteAnterior { get; set; }

    public string ClienteActual { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FechaAlta { get; set; }
}
