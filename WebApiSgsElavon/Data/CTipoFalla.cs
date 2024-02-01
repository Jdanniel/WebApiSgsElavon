using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoFalla
{
    public int IdTipoFalla { get; set; }

    public int? IdCliente { get; set; }

    public string DescTipoFalla { get; set; }

    public string Status { get; set; }

    public int? IsCobrable { get; set; }

    public int? IsEspecial { get; set; }
}
