using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdTrackingLog
{
    public int IdTrackingLog { get; set; }

    public int? IdTipoTracking { get; set; }

    public string Afiliacion { get; set; }

    public string Odt { get; set; }

    public DateTime? FecVisita { get; set; }
}
