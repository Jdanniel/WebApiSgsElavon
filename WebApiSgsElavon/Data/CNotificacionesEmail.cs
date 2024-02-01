using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CNotificacionesEmail
{
    public int IdNotificacionesEmail { get; set; }

    public string DescNotificacion { get; set; }

    public string Valor { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
