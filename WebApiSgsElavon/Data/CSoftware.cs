using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CSoftware
{
    public int IdSoftware { get; set; }

    public string DescSoftware { get; set; }

    public string Descripcion { get; set; }

    public int? IdCliente { get; set; }

    public int? IdProducto { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdModeloSustituto> BdModeloSustitutos { get; set; } = new List<BdModeloSustituto>();
}
