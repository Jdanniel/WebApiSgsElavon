using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdIatum
{
    public int IdIata { get; set; }

    public string Lowzip { get; set; }

    public string Upzip { get; set; }

    public string Ciudad { get; set; }

    public string Iata { get; set; }

    public string Serv { get; set; }

    public string Cargo { get; set; }

    public string Frec { get; set; }

    public string Rotulo { get; set; }
}
