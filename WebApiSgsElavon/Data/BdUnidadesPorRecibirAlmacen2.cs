using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUnidadesPorRecibirAlmacen2
{
    public int IdRecepcion { get; set; }

    public int? IdUnidad { get; set; }

    public string NoSerie { get; set; }

    public string Posicion { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsProcesada { get; set; }
}
