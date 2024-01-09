using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempCadenaProsa
{
    public long? Posicion { get; set; }

    public string Cadena { get; set; }

    public string Nombre { get; set; }

    public string TipoCampo { get; set; }

    public int? LongitudPermitida { get; set; }

    public string Validacion { get; set; }
}
