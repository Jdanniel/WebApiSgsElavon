using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdDatosCierresAplicacion
{
    public int IdDatoCierreAplicacion { get; set; }

    public string Datos { get; set; }

    public string TipoCierre { get; set; }

    public DateTime? FechaCarga { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdAr { get; set; }
}
