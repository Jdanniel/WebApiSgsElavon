using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempBdTelefonosReporte
{
    public string Afiliacion { get; set; }

    public string Telefono { get; set; }

    public string DescripcionNegocio { get; set; }

    public string Rfc { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string TipoServicio { get; set; }

    public string SubtipoServicio { get; set; }

    public string Odt { get; set; }

    public string FechaCierreFormato { get; set; }
}
