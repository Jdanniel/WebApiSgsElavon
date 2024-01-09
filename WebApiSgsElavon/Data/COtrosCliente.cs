using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class COtrosCliente
{
    public int IdOtrosClientes { get; set; }

    public string DescOtrosClientes { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FechaAlta { get; set; }
}
