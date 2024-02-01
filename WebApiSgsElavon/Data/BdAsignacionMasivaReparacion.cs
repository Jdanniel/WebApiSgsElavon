using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAsignacionMasivaReparacion
{
    public int IdAsignacionMasivaReparacion { get; set; }

    public int? IdCargasDiagnosticada { get; set; }

    public string NoSerie { get; set; }

    public string Proveedor { get; set; }

    public string Status { get; set; }

    public string Observaciones { get; set; }
}
