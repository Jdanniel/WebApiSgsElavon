using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoCobro
{
    public int IdTipoCobro { get; set; }

    public string DescTipoCobro { get; set; }

    public int? IsCobrable { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdTipoServicioProducto> BdTipoServicioProductos { get; set; } = new List<BdTipoServicioProducto>();
}
