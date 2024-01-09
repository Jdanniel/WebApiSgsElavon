using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class UnidadesDisponible
{
    public int IdUnidad { get; set; }

    public int? IdTipoResponsable { get; set; }

    public string DescTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public string Responsable { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public string NoSerie { get; set; }

    public int IdStatusUnidad { get; set; }

    public int IdModelo { get; set; }

    public string DescMarca { get; set; }

    public string DescModelo { get; set; }
}
