using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdErrorMasivoConectividadAplicativo
{
    public int IdErrorMasivo { get; set; }

    public string NoSerie { get; set; }

    public string Mensaje { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
