using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoMovAccesorio
{
    public int IdTipoMovAccesorios { get; set; }

    public string Movimiento { get; set; }

    public string Status { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdUsuario { get; set; }
}
