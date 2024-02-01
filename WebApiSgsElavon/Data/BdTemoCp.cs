using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTemoCp
{
    public int IdTipoPlazaClienteCp { get; set; }

    public string Cp { get; set; }

    public int? IsCorrecto { get; set; }
}
