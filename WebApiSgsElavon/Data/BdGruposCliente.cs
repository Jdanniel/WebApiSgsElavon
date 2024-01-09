using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdGruposCliente
{
    public int IdGrupoCliente { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CCliente IdClienteNavigation { get; set; }

    public virtual CGrupo IdGrupoNavigation { get; set; }
}
