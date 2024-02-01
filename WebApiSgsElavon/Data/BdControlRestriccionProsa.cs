using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdControlRestriccionProsa
{
    public int IdControlRestriccionProsa { get; set; }

    public DateTime? FecRestriccion { get; set; }

    public int? IdUsuario { get; set; }

    public string Status { get; set; }
}
