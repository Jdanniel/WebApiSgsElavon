using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUsuarioModuloNotificacione
{
    public int IdUsuarioModuloNotificacion { get; set; }

    public int? IdUsuario { get; set; }

    public int? IsDeployment { get; set; }

    public int? IsMarketing { get; set; }

    public DateTime? FecAlta { get; set; }

    public DateTime? FecModificacion { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdUsuarioModificacion { get; set; }

    public int? IsOdt { get; set; }
}
