using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdApiProveedore
{
    public int IdApiProveedor { get; set; }

    public int? IdProveedor { get; set; }

    public string IdApi { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
