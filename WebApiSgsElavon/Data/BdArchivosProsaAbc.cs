using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArchivosProsaAbc
{
    public int IdArchivosProsaAbc { get; set; }

    public string NombreArchivoOrigen { get; set; }

    public string NombreArchivoSistema { get; set; }

    public DateTime? FechaAlta { get; set; }
}
