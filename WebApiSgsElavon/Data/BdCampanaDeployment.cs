using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCampanaDeployment
{
    public int IdCampanaDeployment { get; set; }

    public int? IdMailjetCampaign { get; set; }

    public string Nombre { get; set; }

    public int? IdPlantilla { get; set; }

    public int? IdListaContacto { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecEnvio { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdTipoCampanaDeployment { get; set; }

    public bool Status { get; set; }

    public string EmailPrueba { get; set; }

    public int? IdEmisor { get; set; }
}
