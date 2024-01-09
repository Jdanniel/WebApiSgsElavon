using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Direccione
{
    public int? IdResponsable { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public int? Cp { get; set; }

    public string Estado { get; set; }

    public string Latitud { get; set; }

    public string Longitud { get; set; }
}
