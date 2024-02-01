using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTiempo
{
    public int IdTiempos { get; set; }

    public int? Horas { get; set; }

    public int? Minutos { get; set; }

    public string Descripcion { get; set; }

    public int? Traslado { get; set; }

    public int? Servicio { get; set; }

    public int? MinTotales { get; set; }
}
