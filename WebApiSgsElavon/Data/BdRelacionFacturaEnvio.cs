using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdRelacionFacturaEnvio
{
    public int IdRelacionFacturaEnvio { get; set; }

    public int? IdEnvio { get; set; }

    public int? IsProcesada { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string NoFactura { get; set; }
}
