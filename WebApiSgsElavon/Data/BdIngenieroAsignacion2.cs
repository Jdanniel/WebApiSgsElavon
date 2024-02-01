using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdIngenieroAsignacion2
{
    public int IdIngenieroAsignacion { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRegion { get; set; }

    public string Status { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }
}
