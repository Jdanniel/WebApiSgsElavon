using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CTiposPlantilla
{
    public int IdTipoPlantilla { get; set; }

    public string DescTipoPlantilla { get; set; }

    public bool? Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
