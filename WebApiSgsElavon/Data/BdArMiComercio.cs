using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdArMiComercio
{
    public int IdArMiComercio { get; set; }

    public int? IdAr { get; set; }

    public int? Notificado { get; set; }

    public int? Promociones { get; set; }

    public int? DescargarApp { get; set; }

    public string Telefono1 { get; set; }

    public string Telefono2 { get; set; }

    public DateTime? FecAlta { get; set; }
}
