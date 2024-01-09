using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdConfigServiciosFallasPrimeraOdt
{
    public int IdConfigServiciosFallasPrimeraOdt { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
