using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCargaCodigoRechazo
{
    public int IdCargaCodigoRechazo { get; set; }

    public string NoAr { get; set; }

    public string Status { get; set; }

    public string DescError { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdCarga { get; set; }
}
