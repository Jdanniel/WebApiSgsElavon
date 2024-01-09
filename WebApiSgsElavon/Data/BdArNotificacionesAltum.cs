using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArNotificacionesAltum
{
    public int IdArNotificacionesAlta { get; set; }

    public int? IdAr { get; set; }

    public int? IdTecnico { get; set; }

    public int? IsEnviado { get; set; }

    public DateTime? FecEnviado { get; set; }

    public string EmailTo { get; set; }
}
