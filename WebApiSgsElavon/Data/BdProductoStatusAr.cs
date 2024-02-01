using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdProductoStatusAr
{
    public int IdProductoStatusAr { get; set; }

    public int? IdProducto { get; set; }

    public int? IdStatusAr { get; set; }

    public string StatusWeb { get; set; }

    public string StatusBb { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public virtual ICollection<BdClienteProductoStatusAr> BdClienteProductoStatusArs { get; set; } = new List<BdClienteProductoStatusAr>();

    public virtual CStatusAr IdStatusArNavigation { get; set; }
}
