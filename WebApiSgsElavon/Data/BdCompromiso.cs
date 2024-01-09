using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCompromiso
{
    public int IdCompromiso { get; set; }

    public int? NombreJunta { get; set; }

    public string DescCompromiso { get; set; }

    public int? IdArea { get; set; }

    public int? IdUsuarioResponsable { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Observaciones { get; set; }

    public DateTime? FecIni { get; set; }

    public DateTime? FecFin { get; set; }

    public DateTime? FecRealTermino { get; set; }

    public int? Calif { get; set; }

    public int? Status { get; set; }

    public int? IdUsuarioResponsableCompromiso { get; set; }

    public string StatusCompromiso { get; set; }

    public string CodigoControl { get; set; }

    public int? IdPrioridades { get; set; }
}
