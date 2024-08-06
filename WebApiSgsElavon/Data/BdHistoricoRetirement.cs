using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdHistoricoRetirement
{
    public int IdHistoricoRetiremen { get; set; }

    public string NoSerie { get; set; }

    public int? IdModelo { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IdRetiro { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdStatusUnidad { get; set; }

    public DateTime? FecAlta { get; set; }
}
