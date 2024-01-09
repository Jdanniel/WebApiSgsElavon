using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdMensajeriaCpZona
{
    public int IdMensajeriaCpZona { get; set; }

    public string CpOrigen { get; set; }

    public string AbreviaturaOrigen { get; set; }

    public int? ZonaOrigen { get; set; }

    public string CpDestino { get; set; }

    public string AbreviaturaDestino { get; set; }

    public int? ZonaDestino { get; set; }

    public int? IdMensajeriaPrecio { get; set; }
}
