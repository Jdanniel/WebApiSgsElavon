using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CCausaRetiro
{
    public int IdCausaRetiro { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdCliente { get; set; }

    public string CausaRetiro { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
