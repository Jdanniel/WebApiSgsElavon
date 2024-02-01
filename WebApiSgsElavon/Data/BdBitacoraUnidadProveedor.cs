using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraUnidadProveedor
{
    public int IdBitacoraUnidadProveedor { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdProveedorAnterior { get; set; }

    public int? IdProveedorActual { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }

    public int? IdAr { get; set; }
}
