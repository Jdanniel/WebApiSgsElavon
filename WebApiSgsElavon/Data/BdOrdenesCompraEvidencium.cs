using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdOrdenesCompraEvidencium
{
    public int IdOrdenesCompraEvidencia { get; set; }

    public string NombreArchivo { get; set; }

    public string NombreSistema { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? UsuarioAlta { get; set; }

    public int? IdOrden { get; set; }
}
