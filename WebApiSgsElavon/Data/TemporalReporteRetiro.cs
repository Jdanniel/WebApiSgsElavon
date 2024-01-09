using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TemporalReporteRetiro
{
    public string OdtMin { get; set; }

    public string NoSerie { get; set; }

    public string DescModelo { get; set; }

    public string NoAr { get; set; }

    public string DescMarca { get; set; }

    public string IsNueva { get; set; }

    public string IsDanada { get; set; }

    public string DescServicio { get; set; }

    public string DescZona { get; set; }

    public string FecCierre { get; set; }

    public string FecCierrePrimerMes { get; set; }

    public int IdAr { get; set; }

    public DateTime? Consulta { get; set; }

    public long? Nro { get; set; }
}
