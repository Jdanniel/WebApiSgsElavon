using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraServiciosFalla1
{
    public int IdBitacoraServiciosFallas { get; set; }

    public int? IdOtrosClientesAnterior { get; set; }

    public int? IdProveedorAnterior { get; set; }

    public int? IsControlAccesorioAnterior { get; set; }

    public int? IdOtrosClientesActual { get; set; }

    public int? IdProveedorActual { get; set; }

    public int? IsControlAccesorioActual { get; set; }
}
