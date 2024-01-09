using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEspecificacionTipoFalla
{
    public int IdEspecifTipoFalla { get; set; }

    public int? IdCliente { get; set; }

    public int? IdFallaParent { get; set; }

    public string DescEspecificacionFalla { get; set; }

    public string Status { get; set; }

    public int? IsCobrable { get; set; }

    public int? NoValidacionNeeded { get; set; }

    public int? IsTirNeeded { get; set; }
}
