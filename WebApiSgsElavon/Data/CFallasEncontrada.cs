using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CFallasEncontrada
{
    public int IdFalla { get; set; }

    public string DescFalla { get; set; }

    public int? IdCliente { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateOnly? FecAlta { get; set; }
}
