using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CReporteMovInventario
{
    public int IdReporteMovInventario { get; set; }

    public DateTime? FecIni { get; set; }

    public DateTime? FecFin { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdReporteMovInventario> BdReporteMovInventarios { get; set; } = new List<BdReporteMovInventario>();
}
