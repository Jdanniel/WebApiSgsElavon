using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNotificacionesOdt
{
    public int IdNotificacionOdt { get; set; }

    public string NombreEnvio { get; set; }

    public int? IdStatusIni { get; set; }

    public int? IdStatusFin { get; set; }

    public int? IdPlantilla { get; set; }

    public bool? IdStatus { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string EmailPrueba { get; set; }

    public string NombreUsuarioPrueba { get; set; }
}
