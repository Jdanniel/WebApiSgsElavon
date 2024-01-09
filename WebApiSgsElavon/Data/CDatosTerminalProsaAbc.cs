using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CDatosTerminalProsaAbc
{
    public int IdDatosTerminalProsaAbc { get; set; }

    public int? Posicion { get; set; }

    public int? Longitud { get; set; }

    public string TipoDato { get; set; }

    public string ValorDefecto { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string TipoCampo { get; set; }

    public string Nombre { get; set; }
}
