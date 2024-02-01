using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoPrecio
{
    public int IdTipoPrecio { get; set; }

    public string DescTipoPrecio { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CServicio> CServicios { get; set; } = new List<CServicio>();
}
