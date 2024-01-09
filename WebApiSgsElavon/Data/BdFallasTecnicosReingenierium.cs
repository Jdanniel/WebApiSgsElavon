using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdFallasTecnicosReingenierium
{
    public int IdServiciosTecnicosReingenieria { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdFalla { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
