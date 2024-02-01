using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CWincorSubmodulo
{
    public int IdSubmodulo { get; set; }

    public int? IdModulo { get; set; }

    public string ClaveSubmodulo { get; set; }

    public string DescSubmodulo { get; set; }

    public string Status { get; set; }
}
