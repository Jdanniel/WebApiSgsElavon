using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoProducto
{
    public int IdTipoProducto { get; set; }

    public string DescTipoProducto { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CProducto> CProductos { get; set; } = new List<CProducto>();
}
