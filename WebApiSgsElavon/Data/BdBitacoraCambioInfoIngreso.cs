using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioInfoIngreso
{
    public int IdBitacoraCambioInfoIngreso { get; set; }

    public string EmailAnterior { get; set; }

    public string EmailActual { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
