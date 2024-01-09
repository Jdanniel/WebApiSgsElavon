using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class VwAmCheck
{
    public DateTime? Fecha { get; set; }

    public int? Año { get; set; }

    public int? Mes { get; set; }

    public int? Semana { get; set; }

    public int? Dia { get; set; }

    public string Regional { get; set; }

    public string NombreIngeniero { get; set; }

    public DateTime? Hora { get; set; }
}
