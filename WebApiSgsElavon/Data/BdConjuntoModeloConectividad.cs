using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdConjuntoModeloConectividad
{
    public int IdConjunto { get; set; }

    public int? IdModeloParent { get; set; }

    public int? IdConectividadParent { get; set; }

    public int? IdConectividad { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
