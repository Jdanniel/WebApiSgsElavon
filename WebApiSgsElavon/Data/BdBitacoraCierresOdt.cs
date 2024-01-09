using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraCierresOdt
{
    public int IdBitacoraCierresOdt { get; set; }

    public string NoAfiliacion { get; set; }

    public int? TotalRollosAnterior { get; set; }

    public int? Insumos { get; set; }

    public int? TotalRollosActual { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
