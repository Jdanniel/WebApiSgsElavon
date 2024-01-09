using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdObservacionesCambioUnidad
{
    public int IdObservacionesCamnbioUnidad { get; set; }

    public int? IdUnidad { get; set; }

    public string Comentario { get; set; }

    public int? IdStatusUnidadEnvio { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string Status { get; set; }
}
