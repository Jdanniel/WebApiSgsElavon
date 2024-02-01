using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioUnidadNueva
{
    public int IdBitacoraCambioUnidadNueva { get; set; }

    public int? IdBitacoraUnidad { get; set; }

    public int? IdUnidad { get; set; }

    public int? IsNueva { get; set; }

    public DateTime? FecAlta { get; set; }
}
