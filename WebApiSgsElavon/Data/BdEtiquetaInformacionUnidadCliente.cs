using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEtiquetaInformacionUnidadCliente
{
    public int IdEtiquetaInformacionUnidadCliente { get; set; }

    public int? IdEtiquetaInformacionUnidad { get; set; }

    public int? IdCliente { get; set; }

    public string DescEtiquetaInformacionUnidadCliente { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
