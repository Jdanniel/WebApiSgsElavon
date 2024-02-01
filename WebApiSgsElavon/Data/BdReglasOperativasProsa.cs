using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdReglasOperativasProsa
{
    public int IdReglaOperativaProsa { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? NoOdt { get; set; }

    public int? IdStatusAr { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
