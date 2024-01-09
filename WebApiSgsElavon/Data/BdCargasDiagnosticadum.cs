using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCargasDiagnosticadum
{
    public int IdCargasDiagnosticada { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IsReparacion { get; set; }
}
