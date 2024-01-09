using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdTiposDeServiciosCosto
{
    public int IdTipoDeServicioCosto { get; set; }

    public int? IdMensajeriaPrecio { get; set; }

    public string Servicio { get; set; }

    public int? IdUrgencia { get; set; }

    public string Status { get; set; }
}
