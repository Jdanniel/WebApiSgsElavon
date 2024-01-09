using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempConsumoTrimestralBancomer
{
    public string Zona { get; set; }

    public int? GprsConSim { get; set; }

    public int? GprsSinSim { get; set; }

    public int? Wifi { get; set; }

    public int? TotalGeneral { get; set; }
}
