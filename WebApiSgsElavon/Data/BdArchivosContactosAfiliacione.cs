using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArchivosContactosAfiliacione
{
    public int IdArchivoContacto { get; set; }

    public string DescArchivo { get; set; }

    public string Archivo { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
