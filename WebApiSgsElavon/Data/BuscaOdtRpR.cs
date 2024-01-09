using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BuscaOdtRpR
{
    public int IdAr { get; set; }

    public string NoAr { get; set; }

    public int? IdArOriginal { get; set; }

    public int? Rp { get; set; }

    public int? Rs { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecAtencion { get; set; }

    public DateTime? FecGarantia { get; set; }

    public string NoAfiliacion { get; set; }

    public string Poblacion { get; set; }

    public string Estado { get; set; }

    public int? IdZona { get; set; }

    public int? CantidadRpRs { get; set; }

    public string Buscar { get; set; }

    public int? IdArRpRs { get; set; }
}
