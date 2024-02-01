using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoTracking
{
    public int IdTipoTracking { get; set; }

    public string DescTipoTracking { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
