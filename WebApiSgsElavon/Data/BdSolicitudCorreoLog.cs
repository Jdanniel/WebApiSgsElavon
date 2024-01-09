using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSolicitudCorreoLog
{
    public int IdSolicitudCorreoLog { get; set; }

    public string IdCorreo { get; set; }

    public DateTime? FechaCorreo { get; set; }

    public string ContenidoEmail { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Mensaje { get; set; }
}
