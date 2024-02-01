using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdVistaEscalamientoStatusAr
{
    public int IdVistaEscalamientoStatusAr { get; set; }

    public int? IdVistaEscalamiento { get; set; }

    public int? IdStatusAr { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CVistasEscalamiento IdVistaEscalamientoNavigation { get; set; }
}
