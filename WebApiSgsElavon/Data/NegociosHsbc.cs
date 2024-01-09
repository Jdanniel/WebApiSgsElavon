using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class NegociosHsbc
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdRegion { get; set; }

    public int? IdZona { get; set; }

    public int? IdSegmento { get; set; }

    public string DescNegocio { get; set; }

    public double? NoAfiliacion { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public int? IdEstado { get; set; }

    public double? Cp { get; set; }

    public string Vip { get; set; }

    public int? IsDuplicated { get; set; }
}
