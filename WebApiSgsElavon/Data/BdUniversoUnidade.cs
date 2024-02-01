using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUniversoUnidade
{
    public int IdUniversoUnidades { get; set; }

    public string NoSerie { get; set; }

    public string MinorCategory { get; set; }

    public string AssetNumber { get; set; }

    public string MajorCategory { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string Status { get; set; }

    public string Observaciones { get; set; }

    public string IdProceso { get; set; }

    public string StatusCarga { get; set; }
}
