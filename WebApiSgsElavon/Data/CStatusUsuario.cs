using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusUsuario
{
    public int IdStatusUsuario { get; set; }

    public string DescStatusUsuario { get; set; }

    public string Status { get; set; }

    public int? RequierePeriodo { get; set; }

    public int? Envios { get; set; }

    public int? Viaticos { get; set; }
}
