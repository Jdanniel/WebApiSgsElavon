using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAfiliacionesProyectoEspecial
{
    public int IdAfiliacionProyEsp { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdProyectoEspecial { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string IsProcesado { get; set; }
}
