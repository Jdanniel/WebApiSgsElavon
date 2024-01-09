using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CConsumible
{
    public int IdConsumible { get; set; }

    public string NoParte { get; set; }

    public string DescConsumible { get; set; }

    public string Marca { get; set; }

    public string Modulo { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FechaAlta { get; set; }

    public int? IdUsuarioStatus { get; set; }

    public DateTime? FechaStatus { get; set; }

    public string Status { get; set; }

    public decimal? Costo { get; set; }
}
