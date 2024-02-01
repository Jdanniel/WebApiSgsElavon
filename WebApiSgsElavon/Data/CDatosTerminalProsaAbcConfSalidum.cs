using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CDatosTerminalProsaAbcConfSalidum
{
    public int IdDatosTerminalProsaAbcConfSalida { get; set; }

    public int? Posicion { get; set; }

    public int? Longitud { get; set; }

    public string NombreCampo { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }
}
