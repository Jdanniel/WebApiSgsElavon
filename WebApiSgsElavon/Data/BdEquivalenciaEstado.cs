using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEquivalenciaEstado
{
    public int IdEquivalenciaEstado { get; set; }

    public string DescEstado { get; set; }

    public string DescEstadoEquivalencia { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
