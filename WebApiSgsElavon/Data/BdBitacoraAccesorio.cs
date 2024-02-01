using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraAccesorio
{
    public int IdBitacoraAccesorios { get; set; }

    public int? IdAccesorio { get; set; }

    public string DescAccesorioAnterior { get; set; }

    public string DescAccesorioActual { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusActual { get; set; }

    public string DescripcionAnterior { get; set; }

    public string DescripcionActual { get; set; }

    public string CostoAnterior { get; set; }

    public string CostoActual { get; set; }

    public int? IdProductoAnterior { get; set; }

    public int? IdProductoActual { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }
}
