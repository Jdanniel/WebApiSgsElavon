using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTempCambioSlaOdt
{
    public int IdTempCambioSlaOdt { get; set; }

    public string Odt { get; set; }

    public string Status { get; set; }

    public string Observacion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdCarga { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FecAltaOdt { get; set; }

    public DateTime? FecGarantiaOdt { get; set; }

    public string IdProyecto { get; set; }
}
