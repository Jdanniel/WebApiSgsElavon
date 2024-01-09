using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CUrgenciaEnvio
{
    public int IdUrgenciaEnvio { get; set; }

    public string DescUrgenciaEnvio { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdEnvio> BdEnvios { get; set; } = new List<BdEnvio>();
}
