using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusEnvio
{
    public int IdStatusEnvio { get; set; }

    public string DescStatusEnvio { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdEnvio> BdEnvios { get; set; } = new List<BdEnvio>();
}
