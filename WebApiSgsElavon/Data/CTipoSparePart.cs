using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTipoSparePart
{
    public int IdTipoSparePart { get; set; }

    public string DescTipoSparePart { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CSparePart> CSpareParts { get; set; } = new List<CSparePart>();
}
