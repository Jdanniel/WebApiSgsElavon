using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAsignacionTecnicoArLog
{
    public int IdAsignacionTecnicoArLog { get; set; }

    public string Odt { get; set; }

    public string Tecnico { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public string Error { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdCargaMasiva { get; set; }
}
