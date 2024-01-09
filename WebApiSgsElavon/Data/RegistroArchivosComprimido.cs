using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class RegistroArchivosComprimido
{
    public int IdRegistroArchivoComprimido { get; set; }

    public string Nombre { get; set; }

    public DateTime? FecRegistro { get; set; }

    public string Carpeta { get; set; }
}
