using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArchivosPrefacturacion
{
    public int IdArchivoPrefacturacion { get; set; }

    public int? IdArPrefacturacion { get; set; }

    public int? IdStatusCargaArchivoPrefacturacion { get; set; }

    public string NombreArchivoPrefacturacionSystem { get; set; }

    public string NombreArchivoPrefacturacionUser { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
