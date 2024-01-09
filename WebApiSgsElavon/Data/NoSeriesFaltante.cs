using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class NoSeriesFaltante
{
    public int IdNoSeriesFaltantes { get; set; }

    public string NoSerie { get; set; }

    public int? SinInstalacionRetiro { get; set; }
}
