using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUsuarioZona
{
    public int IdUsuarioZona { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
