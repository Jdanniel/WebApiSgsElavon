using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class SepomexEstado
{
    public int IdEstado { get; set; }

    public string Estado { get; set; }

    public string Status { get; set; }

    public string Abreviatura { get; set; }

    public virtual ICollection<BdClaveEstado> BdClaveEstados { get; set; } = new List<BdClaveEstado>();

    public virtual ICollection<BdNegocio> BdNegocios { get; set; } = new List<BdNegocio>();
}
