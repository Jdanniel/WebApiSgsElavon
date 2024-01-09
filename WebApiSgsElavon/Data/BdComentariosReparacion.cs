using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdComentariosReparacion
{
    public int IdComentariosReparacion { get; set; }

    public int? IdReparacionUnidad { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
