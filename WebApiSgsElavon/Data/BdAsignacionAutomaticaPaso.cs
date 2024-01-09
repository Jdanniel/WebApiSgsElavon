using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdAsignacionAutomaticaPaso
{
    public int IdAsignacionAutomaticaPaso { get; set; }

    public int? IdCarga { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdTecnico { get; set; }

    public int? IdCliente { get; set; }

    public string Cp { get; set; }

    public int? IsProcesada { get; set; }

    public string Mensaje { get; set; }
}
