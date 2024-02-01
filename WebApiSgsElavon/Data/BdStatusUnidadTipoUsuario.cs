using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdStatusUnidadTipoUsuario
{
    public int IdStatusUnidadTipoUsuario { get; set; }

    public int? IdTipoUsuario { get; set; }

    public int? IdStatusUnidad { get; set; }

    public int? IsInicio { get; set; }
}
