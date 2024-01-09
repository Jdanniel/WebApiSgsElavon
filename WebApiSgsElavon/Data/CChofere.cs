using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CChofere
{
    public int IdChofer { get; set; }

    public int IdServicioMensajeria { get; set; }

    public string Nombre { get; set; }

    public string Paterno { get; set; }

    public string Materno { get; set; }

    public string Status { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccions { get; set; } = new List<BdSolicitudRecoleccion>();
}
