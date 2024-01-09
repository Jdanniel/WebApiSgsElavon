using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdDatosEnvioSalesforce
{
    public int IdDatoEnvioSalesforce { get; set; }

    public string Datos { get; set; }

    public string TipoCierre { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdAr { get; set; }

    public string Error { get; set; }

    public string IdProcesoMasivo { get; set; }

    public string Ruta { get; set; }

    public int? InReview { get; set; }

    public string Status { get; set; }
}
