using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdEnviosEmail
{
    public int IdEnvioEmail { get; set; }

    public string NombreEnvio { get; set; }

    public string Asunto { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdPlantillaEmail { get; set; }

    public int? IdModelo { get; set; }

    public DateTime? FecIni { get; set; }

    public DateTime? FecFin { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string Nombre { get; set; }

    public string Toemail { get; set; }
}
