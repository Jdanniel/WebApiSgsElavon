using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNegociosNuevosNotificacion
{
    public int IdNegocioNuevoNotificacion { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IsEnviado { get; set; }

    public DateTime? FecEnviado { get; set; }
}
