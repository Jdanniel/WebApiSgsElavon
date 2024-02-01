using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdColumnsLayout
{
    public int IdColumnLayout { get; set; }

    public int? IdLayout { get; set; }

    public string DescColumnLayout { get; set; }

    public int? Orden { get; set; }

    public bool? Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
