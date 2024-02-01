using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTiposDeServiciosCosto
{
    public int IdTipoDeServicioCosto { get; set; }

    public int? IdMensajeriaPrecio { get; set; }

    public string Servicio { get; set; }

    public int? IdUrgencia { get; set; }

    public string Status { get; set; }
}
