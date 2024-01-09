using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class RespaldoCProductosNegocio
{
    public int IdProductoNegocio { get; set; }

    public string DescProductoNegocio { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
