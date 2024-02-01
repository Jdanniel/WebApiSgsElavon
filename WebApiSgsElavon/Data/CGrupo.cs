using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CGrupo
{
    public int IdGrupo { get; set; }

    public string DescGrupo { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdDocsTir { get; set; }

    public virtual ICollection<BdGruposCliente> BdGruposClientes { get; set; } = new List<BdGruposCliente>();
}
