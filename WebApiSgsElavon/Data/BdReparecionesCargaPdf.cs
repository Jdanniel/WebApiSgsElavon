using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReparecionesCargaPdf
{
    public int IdReparacionCargaPdf { get; set; }

    public int? IdUnidad { get; set; }

    public string ArchivoUsuario { get; set; }

    public string ArchivoSistema { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
