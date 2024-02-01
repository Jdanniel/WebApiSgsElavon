using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCostoViatico
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Secuencia { get; set; }

    public string Region { get; set; }

    public string Zona { get; set; }

    public string DescCliente { get; set; }

    public int? IdSolicitud { get; set; }

    public int? IdAr { get; set; }

    public string FecConfirmación { get; set; }

    public string DescViatico { get; set; }

    public string Usuario { get; set; }

    public string Motivo { get; set; }

    public decimal? Costo { get; set; }

    public string Status { get; set; }
}
