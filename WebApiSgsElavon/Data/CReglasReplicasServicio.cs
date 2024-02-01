using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CReglasReplicasServicio
{
    public int IdReglasReplicasServicio { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? Fecha { get; set; }
}
