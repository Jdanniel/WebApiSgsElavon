using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdRfcCliente
{
    public int IdRfcClientes { get; set; }

    public string Rfc { get; set; }

    public string Cliente { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
