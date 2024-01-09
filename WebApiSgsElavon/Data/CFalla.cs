using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CFalla
{
    public int IdFalla { get; set; }

    public int IdCliente { get; set; }

    public string DescFalla { get; set; }

    public string Codigo { get; set; }

    public int? IsDowntime { get; set; }

    public int? IdTipoFalla { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
