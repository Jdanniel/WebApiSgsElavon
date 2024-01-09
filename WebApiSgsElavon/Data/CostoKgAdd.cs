using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CostoKgAdd
{
    public int IdCostoKgAdd { get; set; }

    public int? IdMensajeriasPrecio { get; set; }

    public decimal? Costo { get; set; }

    public int? Zona { get; set; }

    public int? IdTipoDeServicioCosto { get; set; }

    public int? MaxKgAplicable { get; set; }
}
