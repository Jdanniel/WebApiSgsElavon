using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CPlantillasEmail
{
    public int IdPlantillaEmail { get; set; }

    public string DescPlantilla { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdMailjet { get; set; }

    public bool? Status { get; set; }
}
