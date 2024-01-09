using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdServiciosFallasProyectosSalesforce
{
    public int IdServicioFallaProyectoSalesforce { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public bool? Status { get; set; }
}
