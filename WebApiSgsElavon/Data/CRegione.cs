using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CRegione
{
    public int IdRegion { get; set; }

    public string DescRegion { get; set; }

    public string Descripcion { get; set; }

    public string Color { get; set; }

    public string Status { get; set; }

    public virtual ICollection<CZona> CZonas { get; set; } = new List<CZona>();
}
