using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCadenaProsa
{
    public int? IdAr { get; set; }

    public int? Posicion { get; set; }

    public string Cadena { get; set; }

    public string Nombre { get; set; }

    public string TipoCampo { get; set; }

    public int? LongitudPermitida { get; set; }

    public string Validacion { get; set; }
}
