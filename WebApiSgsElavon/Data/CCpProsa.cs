using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CCpProsa
{
    public int IdCpProsa { get; set; }

    public string Cp { get; set; }

    public string Estado { get; set; }

    public string Poblacion { get; set; }

    public string Municipio { get; set; }

    public string Colonia { get; set; }

    public int? Zona { get; set; }

    public string Estatus { get; set; }

    public DateTime? FechaCarga { get; set; }
}
