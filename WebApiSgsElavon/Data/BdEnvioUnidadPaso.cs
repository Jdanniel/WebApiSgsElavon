using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEnvioUnidadPaso
{
    public int? IdEnvio { get; set; }

    public int? IdUnidad { get; set; }

    public int? IsRecibida { get; set; }

    public DateTime? FechaAlta { get; set; }
}
