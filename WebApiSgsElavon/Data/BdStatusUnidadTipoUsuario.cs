using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdStatusUnidadTipoUsuario
{
    public int IdStatusUnidadTipoUsuario { get; set; }

    public int? IdTipoUsuario { get; set; }

    public int? IdStatusUnidad { get; set; }

    public int? IsInicio { get; set; }
}
