using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CMcBoleto
{
    public int IdBoleto { get; set; }

    public string DescNombre { get; set; }

    public string Costo { get; set; }

    public string Estatus { get; set; }
}
