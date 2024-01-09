using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArTerminalAsociadaAmex
{
    public int IdArTerminalAsociadaAmex { get; set; }

    public int? IdAr { get; set; }

    public string IdTerminalAmex { get; set; }

    public string AfiliacionTerminalAmex { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
