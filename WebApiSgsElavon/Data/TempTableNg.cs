using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempTableNg
{
    public string DescNegocio { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescZona { get; set; }

    public string DescRegion { get; set; }

    public string Direccion { get; set; }

    public string Colonia { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public string Cp { get; set; }

    public int IdNegocio { get; set; }

    public string Image { get; set; }

    public string Status { get; set; }

    public DateTime? FecMigracion { get; set; }

    public int Aproximado { get; set; }

    public string Telefono { get; set; }

    public string DescCliente { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public string Segmento { get; set; }

    public int IdUsuario { get; set; }
}
