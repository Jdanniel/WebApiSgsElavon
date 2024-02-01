using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCambioStatusUnidad
{
    public int IdCambioStatusUnidad { get; set; }

    public string DescStatusUnidadActual { get; set; }

    public string DescStatusUnidadFinal { get; set; }

    public string StatusActual { get; set; }

    public string StatusFinal { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? UsuarioAlta { get; set; }
}
