using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdControlKitTecnico
{
    public int IdKitTecnico { get; set; }

    public int? IdInsumo { get; set; }

    public int? IdAr { get; set; }

    public int? Cantidad { get; set; }

    public int? ControlInsumo { get; set; }

    public int? AproboCantidad { get; set; }
}
