using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CNombreJuntum
{
    public int IdNombreJunta { get; set; }

    public string NombreJunta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public int? NeedArea { get; set; }
}
