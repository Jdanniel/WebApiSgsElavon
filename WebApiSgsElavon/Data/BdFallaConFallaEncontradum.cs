using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdFallaConFallaEncontradum
{
    public int IdFallaFallaEncontrada { get; set; }

    public int? IdFallaPadre { get; set; }

    public int? IdFallaHijo { get; set; }

    public int? IdCliente { get; set; }

    public string Status { get; set; }
}
