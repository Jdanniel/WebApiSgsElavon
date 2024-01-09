using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdRfcClientesPaso
{
    public int IdRfcClientesPaso { get; set; }

    public int? IdCargasNegociosOtrosClientes { get; set; }

    public string Rfc { get; set; }

    public string Cliente { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public string Observaciones { get; set; }
}
