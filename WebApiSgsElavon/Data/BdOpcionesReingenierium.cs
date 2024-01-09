using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdOpcionesReingenierium
{
    public int IdOpcionesReingenieria { get; set; }

    public string Opcion { get; set; }

    public string Status { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaAlta { get; set; }
}
