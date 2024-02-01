using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdZonasCp
{
    public int IdZonasCp { get; set; }

    public string AbreviaturaOrigen { get; set; }

    public string AbreviaturaDestino { get; set; }

    public int? Zona { get; set; }
}
