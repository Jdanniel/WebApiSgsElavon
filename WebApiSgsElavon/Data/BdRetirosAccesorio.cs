using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdRetirosAccesorio
{
    public int IdRetirosAccesorios { get; set; }

    public int? IdAr { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdAccesorio { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
