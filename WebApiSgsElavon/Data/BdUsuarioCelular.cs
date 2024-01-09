using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUsuarioCelular
{
    public int IdUsuarioCelular { get; set; }

    public int? IdUsuario { get; set; }

    public string Celular { get; set; }

    public int? IdTipoPlan { get; set; }

    public int? IdModeloCelular { get; set; }

    public DateTime? FecIniPlan { get; set; }

    public DateTime? FecFinPlan { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public string Imei { get; set; }
}
