using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CDescripcionTrabajo
{
    public int IdDescripcionTrabajo { get; set; }

    public int? IdEspecifTipoFalla { get; set; }

    public string DescTrabajo { get; set; }

    public string Status { get; set; }
}
