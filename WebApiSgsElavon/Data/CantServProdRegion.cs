using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CantServProdRegion
{
    public string DescRegion { get; set; }

    public int? CantServAtm { get; set; }

    public int? CantServModem { get; set; }

    public int? CantServOtros { get; set; }

    public int? CantServSeguridad { get; set; }

    public int? CantServTnm { get; set; }

    public int? CantServTpv { get; set; }

    public int? CantServTresM { get; set; }
}
