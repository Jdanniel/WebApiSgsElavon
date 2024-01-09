using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CCausa
{
    public int IdCausa { get; set; }

    public string DescCausa { get; set; }

    public string Descripcion { get; set; }

    public int? IdCliente { get; set; }

    public string Clave { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual ICollection<BdServicioCausa> BdServicioCausas { get; set; } = new List<BdServicioCausa>();
}
