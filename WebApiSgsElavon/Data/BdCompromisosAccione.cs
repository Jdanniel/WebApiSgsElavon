using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCompromisosAccione
{
    public int IdCompromisosAcciones { get; set; }

    public int? IdCompromiso { get; set; }

    public string DescAccion { get; set; }

    public int? Porcentaje { get; set; }

    public int? AccionConcluida { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }
}
