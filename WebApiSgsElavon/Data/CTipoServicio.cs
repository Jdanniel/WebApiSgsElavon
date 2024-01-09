using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoServicio
{
    public int IdTipoServicio { get; set; }

    public string DescTipoServicio { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdTipoServicioProducto> BdTipoServicioProductos { get; set; } = new List<BdTipoServicioProducto>();

    public virtual ICollection<CServicio> CServicios { get; set; } = new List<CServicio>();
}
