using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTiemposServiciosWincor
{
    public int IdWincorTiempo { get; set; }

    public int? Tr { get; set; }

    public int? Ts { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
