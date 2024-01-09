using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class Tmp01
{
    public string NoSerie { get; set; }

    public int IdModelo { get; set; }

    public int IdStatusUnidad { get; set; }

    public string DescStatusUnidad { get; set; }

    public int? IdTipoResponsable { get; set; }

    public string DescTipoResponsable { get; set; }

    public int? IdResponsable { get; set; }

    public string Responsable { get; set; }

    public string ZonaResponsable { get; set; }

    public string IsDaniada { get; set; }

    public string ResponsableOrigen { get; set; }

    public string ResponsableDestino { get; set; }

    public string ZonaDestino { get; set; }

    public string Guia { get; set; }

    public DateTime? FechaUltimoMovimientoBitacora { get; set; }
}
