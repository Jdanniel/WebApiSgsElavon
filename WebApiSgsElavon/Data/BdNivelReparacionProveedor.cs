using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdNivelReparacionProveedor
{
    public int IdNivelReparacionProveedor { get; set; }

    public int? IdNivelReparacion { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
