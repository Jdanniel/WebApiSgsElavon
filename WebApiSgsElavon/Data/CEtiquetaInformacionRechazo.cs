using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CEtiquetaInformacionRechazo
{
    public int IdEtiquetaInformacionRechazo { get; set; }

    public string DescEtiquetaInformacionRechazo { get; set; }

    public string Tipo { get; set; }

    public string Ruta { get; set; }

    public string CampoServicio { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
