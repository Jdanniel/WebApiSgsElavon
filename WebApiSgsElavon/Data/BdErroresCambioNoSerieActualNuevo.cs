using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdErroresCambioNoSerieActualNuevo
{
    public string NoSerieActua { get; set; }

    public string NoSerieNuevo { get; set; }

    public string Error { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? Status { get; set; }
}
