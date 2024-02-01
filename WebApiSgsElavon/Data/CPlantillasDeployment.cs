using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CPlantillasDeployment
{
    public int IdPlantillaDeployment { get; set; }

    public string DescPlantilla { get; set; }

    public string Archivo { get; set; }

    public bool? Estatus { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
