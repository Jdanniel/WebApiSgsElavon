using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CZona
{
    public int IdZona { get; set; }

    public int? IdRegion { get; set; }

    public string DescZona { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public int? OrdenF11 { get; set; }

    public string CadenaF11 { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public bool? Frontera { get; set; }

    public int? IsAsignacionAuto { get; set; }

    public int? IsTravelProcess { get; set; }

    public virtual CRegione IdRegionNavigation { get; set; }
}
