using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCArgasArchivo
{
    public int IdCargaArchivo { get; set; }

    public int? IdCarga { get; set; }

    public string NombreArchivoSistema { get; set; }

    public string NombreArchivoUsuario { get; set; }
}
