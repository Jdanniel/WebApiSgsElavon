using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdComprobacionSolicitudesViatico
{
    public int IdComprobacionSolicitudesViaticos { get; set; }

    public int IdUsuarioSolicitado { get; set; }

    public decimal? MontoComprobado { get; set; }

    public DateTime FecCorteSolicitudesViaticos { get; set; }

    public string Status { get; set; }
}
