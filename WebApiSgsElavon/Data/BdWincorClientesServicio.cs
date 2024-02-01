using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdWincorClientesServicio
{
    public int IdClienteServicioWincor { get; set; }

    public int IdClienteWincor { get; set; }

    public int IdServicioWincor { get; set; }

    public int? IdFalla { get; set; }

    public int? IdServicio { get; set; }
}
