using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CUnidadMensajerium
{
    public int IdUnidadMensajeria { get; set; }

    public int IdServicioMensajeria { get; set; }

    public string DescUnidadMensajeria { get; set; }

    public string Status { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public virtual ICollection<BdSolicitudRecoleccion> BdSolicitudRecoleccions { get; set; } = new List<BdSolicitudRecoleccion>();
}
