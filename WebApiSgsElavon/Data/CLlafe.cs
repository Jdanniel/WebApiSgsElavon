using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CLlafe
{
    public int IdLlave { get; set; }

    public string DescLlave { get; set; }

    public string Descripcion { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdModeloLlave> BdModeloLlaves { get; set; } = new List<BdModeloLlave>();
}
