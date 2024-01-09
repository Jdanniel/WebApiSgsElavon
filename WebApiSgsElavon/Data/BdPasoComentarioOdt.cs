using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdPasoComentarioOdt
{
    public string NoAr { get; set; }

    public string Comentario { get; set; }

    public string Status { get; set; }

    public int? IdUsuario { get; set; }

    public string Observacion { get; set; }

    public DateTime? FechaAlta { get; set; }
}
