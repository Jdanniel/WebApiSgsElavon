using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class FillRateOtro
{
    public int IdCliente { get; set; }

    public string DescRegion { get; set; }

    public string DescZona { get; set; }

    public int IdMarca { get; set; }

    public string DescMarca { get; set; }

    public int IdModelo { get; set; }

    public string DescModelo { get; set; }

    public int? Instaladas { get; set; }

    public decimal? ConsumoMinimo { get; set; }

    public decimal? ConsumoMinimo2 { get; set; }

    public int? Disponibles { get; set; }

    public int? EnTransito { get; set; }

    public decimal? PorEnviar { get; set; }

    public decimal? Calificacion { get; set; }
}
