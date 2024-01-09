using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdPasoConsolidado
{
    public int IdConsolidado { get; set; }

    public int? IdSolicitud { get; set; }

    public int? IsConsolidado { get; set; }

    public string Status { get; set; }

    public int? IdUsuario { get; set; }
}
