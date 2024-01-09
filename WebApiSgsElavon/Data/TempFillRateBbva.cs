using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempFillRateBbva
{
    public string ZonaConsumo { get; set; }

    public int? GprsConSimConsumo { get; set; }

    public int? GprsSinSimConsumo { get; set; }

    public int? WifiConsumo { get; set; }

    public int? TotalGeneralConsumo { get; set; }

    public int? GprsConSimNivelStock { get; set; }

    public int? GprsSinSimNivelStock { get; set; }

    public int? WifiNivelStock { get; set; }

    public int? TotalGeneralNivelStock { get; set; }

    public int GprsConSimDisponible { get; set; }

    public int GprsSinSimDisponible { get; set; }

    public int WifiDisponible { get; set; }

    public int TotalGeneralDisponible { get; set; }

    public int? GprsConSimSurtido { get; set; }

    public int? GprsSinSimSurtido { get; set; }

    public int? WifiSurtido { get; set; }
}
