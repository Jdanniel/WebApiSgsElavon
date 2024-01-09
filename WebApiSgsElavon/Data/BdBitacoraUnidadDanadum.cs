using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraUnidadDanadum
{
    public int IdBitacoraUnidadDanada { get; set; }

    public int? IdUnidad { get; set; }

    public int? IsDaniadaActual { get; set; }

    public int? IsDaniadaNuevo { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public virtual BdUnidade IdUnidadNavigation { get; set; }
}
