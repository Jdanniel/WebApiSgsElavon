using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUnidadesPorRecibirAlmacen
{
    public int IdRecepcion { get; set; }

    public string NoSerie { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdJefeAlmacen { get; set; }

    public int IsProcesada { get; set; }

    public string PosicionInventario { get; set; }
}
