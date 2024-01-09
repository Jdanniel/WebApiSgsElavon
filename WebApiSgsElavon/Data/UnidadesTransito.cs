using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class UnidadesTransito
{
    public int IdModelo { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdEnvio { get; set; }

    public int? IdUnidad { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }

    public string DescStatusEnvio { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public string RegionDestino { get; set; }

    public string ZonaDestino { get; set; }

    public string ResponsableDestino { get; set; }
}
