using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdPreciosLicenciaAndroid
{
    public int IdPrecioLicencia { get; set; }

    public string RangoLicencia { get; set; }

    public decimal? CostoMensual { get; set; }
}
