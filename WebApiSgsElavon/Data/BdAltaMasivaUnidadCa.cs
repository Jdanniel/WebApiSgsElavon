using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAltaMasivaUnidadCa
{
    public int IdUnidadCa { get; set; }

    public int? IdCarga { get; set; }

    public string NoSerie { get; set; }

    public int? IdModelo { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IdUsuario { get; set; }

    public string Status { get; set; }

    public string Error { get; set; }
}
