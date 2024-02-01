using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraBorrarUnidad
{
    public int IdBitacoraBorrarUnidad { get; set; }

    public int IdUnidad { get; set; }

    public DateTime? FecBorrado { get; set; }

    public int IdUsuarioBorrado { get; set; }
}
