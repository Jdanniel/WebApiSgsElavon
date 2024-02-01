using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraAplicativoUnidad
{
    public int IdAplicativoUnidad { get; set; }

    public int? IdAr { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdAplicativoViejo { get; set; }

    public int? IdAplicativoNuevo { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }
}
