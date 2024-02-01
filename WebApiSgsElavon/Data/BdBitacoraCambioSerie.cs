using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioSerie
{
    public int IdBitacora { get; set; }

    public int? IdUnidad { get; set; }

    public string Serie { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string NoSerieNew { get; set; }
}
