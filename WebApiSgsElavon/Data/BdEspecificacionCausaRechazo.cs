using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEspecificacionCausaRechazo
{
    public int IdEspecificacionCausaRechazo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdCausaRechazoParent { get; set; }

    public string DescEspecificacionCausaRechazo { get; set; }

    public string Status { get; set; }

    public int? NoValidacionNeeded { get; set; }

    public int? IsTirNeeded { get; set; }
}
