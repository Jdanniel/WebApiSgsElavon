using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEnviosEmailsDeployment
{
    public int IdEnvioEmailDeployment { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdPlantillaDeployment { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public int? IdModelo { get; set; }

    public DateTime? FecInicio { get; set; }

    public DateTime? FecFin { get; set; }

    public string AsuntoEmail { get; set; }

    public string CuerpoEmail { get; set; }

    public string TituloEmail { get; set; }

    public string NombreNotificacion { get; set; }

    public string EmailDestino { get; set; }
}
