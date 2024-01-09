using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CReglaCancelacionServiciosFalla
{
    public int IdReglaCancelacionServiciosFallas { get; set; }

    public int? IdServicio { get; set; }

    public int? IdFalla { get; set; }

    public int? IdTipoCancelacion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
