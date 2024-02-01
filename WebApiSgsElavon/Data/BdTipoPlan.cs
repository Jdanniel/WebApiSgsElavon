using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTipoPlan
{
    public int IdTipoPlan { get; set; }

    public string DescTipoPlan { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
