using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CServiciosSubserviciosReingenieriaLogBorrar
{
    public int IdServiciosSubserviciosReingenieria { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }
}
