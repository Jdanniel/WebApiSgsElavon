using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CPrioridade
{
    public int IdPrioridades { get; set; }

    public string DescPrioridades { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }
}
