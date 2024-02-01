using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CCategorium
{
    public int IdCategoria { get; set; }

    public string DescCategoria { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
