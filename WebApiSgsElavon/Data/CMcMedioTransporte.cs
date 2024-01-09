using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CMcMedioTransporte
{
    public int IdMedioTransporte { get; set; }

    public string DescNombre { get; set; }

    public string Estatus { get; set; }

    public string CostoPorKm { get; set; }

    public string CostoPorMantenimiento { get; set; }

    public bool? IsCasetas { get; set; }

    public bool? IsAutobus { get; set; }

    public bool? IsMantenimiento { get; set; }

    public string CostoPorCaseta { get; set; }
}
