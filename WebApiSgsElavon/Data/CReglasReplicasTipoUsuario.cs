using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CReglasReplicasTipoUsuario
{
    public int IdReglasReplicasTipoUsuario { get; set; }

    public int? IdTipoUsuario { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? Fecha { get; set; }
}
