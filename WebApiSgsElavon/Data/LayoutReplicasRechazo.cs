using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class LayoutReplicasRechazo
{
    public string Odt { get; set; }

    public string CausaRechazo { get; set; }

    public string SubRechazo { get; set; }

    public string Zona { get; set; }

    public string Afiliacion { get; set; }

    public DateOnly? FechaAlta { get; set; }

    public DateOnly? FechaGeneracion { get; set; }

    public string Estatus { get; set; }

    public int? DiasSinInstalar { get; set; }

    public string IdEquipo { get; set; }

    public string IdCaja { get; set; }

    public string SubTipoServicio { get; set; }

    public string Conclusiones { get; set; }

    public string EjecutivoKa { get; set; }
}
