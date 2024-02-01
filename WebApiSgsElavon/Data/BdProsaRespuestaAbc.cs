using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdProsaRespuestaAbc
{
    public int IdProsaRespuestaAbc { get; set; }

    public string Cadena { get; set; }

    public string Status { get; set; }

    public string NombreArchivo { get; set; }

    public int? IdArchivosProsaAbc { get; set; }
}
