using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdNegociosServiciosDoble
{
    public int IdNegocioServicioDoble { get; set; }

    public int? IdServicioDoble { get; set; }

    public string NoAfiliacion { get; set; }

    public string DescripcionServicioDoble { get; set; }

    public string Mensaje { get; set; }

    public string Status { get; set; }

    public int? IsExito { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
