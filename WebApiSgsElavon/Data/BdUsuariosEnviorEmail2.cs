using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUsuariosEnviorEmail2
{
    public int IdUsuariosEnviorEmail2 { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdNotificacionesEmail { get; set; }

    public string Checked { get; set; }

    public string Status { get; set; }
}
