using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempCargaUnidade
{
    public int IdCargaUnidades { get; set; }

    public int? IdCarga { get; set; }

    public int? IdModelo { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public int? IsNueva { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IdResponsable { get; set; }

    public decimal? Costo { get; set; }

    public int? IdMoneda { get; set; }

    public string Status { get; set; }

    public string DescModelo { get; set; }

    public string DescripcionConectividad { get; set; }

    public string DescripcionAplicativo { get; set; }
}
