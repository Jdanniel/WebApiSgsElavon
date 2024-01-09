using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TablaRemesaBbvaReporte
{
    public int? Ticket { get; set; }

    public int? Afiliacion { get; set; }

    public string NoSerie { get; set; }

    public string Remesa { get; set; }

    public string Estatus { get; set; }

    public DateOnly? Fecha { get; set; }
}
