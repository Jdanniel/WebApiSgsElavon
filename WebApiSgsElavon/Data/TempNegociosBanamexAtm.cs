using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempNegociosBanamexAtm
{
    public string NoAfiliacion { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public int? IdEstado { get; set; }

    public string Cp { get; set; }
}
