using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUsuariosNotificacionesAltum
{
    public int IdUsuarioNotificacionAlta { get; set; }

    public int? IdUsuario { get; set; }

    public bool Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdTemplateMailjet { get; set; }

    public int? IdEmisorEmail { get; set; }
}
