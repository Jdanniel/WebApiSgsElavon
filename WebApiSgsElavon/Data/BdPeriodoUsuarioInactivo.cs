using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdPeriodoUsuarioInactivo
{
    public int IdPeriodoUsuarioInactivo { get; set; }

    public int? IdUsuarioCambio { get; set; }

    public int? IdUsuario { get; set; }

    public string StatusUsuario { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecFin { get; set; }

    public DateTime? FecCambio { get; set; }

    public string Status { get; set; }
}
