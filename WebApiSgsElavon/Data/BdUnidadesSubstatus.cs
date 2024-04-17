using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUnidadesSubstatus
{
    public int IdUnidadesSubstatus { get; set; }

    public int? IdStatusUnidad { get; set; }

    public int? IdSubstatusUnidad { get; set; }

    public DateTime? FechaInicio { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }

    public string NoAfiliacion { get; set; }
}
