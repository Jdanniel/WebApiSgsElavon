using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class EdoResultado
{
    public int Id { get; set; }

    public int? IdRubro { get; set; }

    public int? IdRegion { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public double? Importe { get; set; }
}
