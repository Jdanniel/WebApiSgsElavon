using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdModeloCelular
{
    public int IdModeloCelular { get; set; }

    public string DescModeloCelular { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
