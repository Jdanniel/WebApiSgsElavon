using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CMovInv
{
    public int IdMovInv { get; set; }

    public string DescMovInv { get; set; }

    public string Corto { get; set; }

    public string Href { get; set; }

    public string Status { get; set; }

    public int? IsObligatorio { get; set; }

    public virtual ICollection<BdServicioMovInv> BdServicioMovInvs { get; set; } = new List<BdServicioMovInv>();
}
