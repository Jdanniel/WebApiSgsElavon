using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdIngenieroAsignacion
{
    public int IdIngenieroAsignacion { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRegion { get; set; }

    public string Status { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }
}
