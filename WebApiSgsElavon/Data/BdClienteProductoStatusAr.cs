using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdClienteProductoStatusAr
{
    public int IdClienteProductoStatusAr { get; set; }

    public int IdCliente { get; set; }

    public int IdProductoStatusAr { get; set; }

    public DateTime FecAlta { get; set; }

    public int IdUsuarioAlta { get; set; }

    public virtual ICollection<BdReglasStatusAr> BdReglasStatusArs { get; set; } = new List<BdReglasStatusAr>();

    public virtual BdProductoStatusAr IdProductoStatusArNavigation { get; set; }
}
