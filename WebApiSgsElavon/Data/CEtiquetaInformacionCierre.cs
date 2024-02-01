using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CEtiquetaInformacionCierre
{
    public int IdEtiquetaInformacionCierre { get; set; }

    public string DescEtiquetaInformacionCierre { get; set; }

    public string Tipo { get; set; }

    public string Ruta { get; set; }

    public string CampoServicio { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
