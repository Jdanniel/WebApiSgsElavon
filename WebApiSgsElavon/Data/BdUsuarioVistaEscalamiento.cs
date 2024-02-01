using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUsuarioVistaEscalamiento
{
    public int IdUsuarioVistaEscalamiento { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdVistaEscalamiento { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CVistasEscalamiento IdVistaEscalamientoNavigation { get; set; }
}
