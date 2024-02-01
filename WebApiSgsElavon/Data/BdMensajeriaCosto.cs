using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdMensajeriaCosto
{
    public int IdPrecioMensajeria { get; set; }

    public int? IdMensajeriasPrecio { get; set; }

    public int? Zona { get; set; }

    public decimal? Kilos { get; set; }

    public int? IdTipoServicioCosto { get; set; }

    public decimal? Costo { get; set; }
}
