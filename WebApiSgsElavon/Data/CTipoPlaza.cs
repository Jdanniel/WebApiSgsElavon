using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoPlaza
{
    public int IdTipoPlaza { get; set; }

    public string DescTipoPlaza { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CPlaza> CPlazas { get; set; } = new List<CPlaza>();
}
