using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempReporteFillRateBancomer
{
    public string Ar { get; set; }

    public string Cliente { get; set; }

    public string Afiliacion { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public string Negocio { get; set; }

    public string Tecnico { get; set; }

    public string FechaDeCierre { get; set; }

    public string Status { get; set; }

    public string NoSerieEntra { get; set; }

    public string TipoComunicacion { get; set; }

    public string MarcaEntra { get; set; }

    public string ModeloEntra { get; set; }

    public string FechaDeInventario { get; set; }

    public DateTime? FecCierre { get; set; }
}
