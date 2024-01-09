using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdAttachDhl
{
    public int IdAttachDhl { get; set; }

    public string NoFactura { get; set; }

    public int? IdCarga { get; set; }

    public string NombreArchivoUsuario { get; set; }

    public string NombreArchivoSistema { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
