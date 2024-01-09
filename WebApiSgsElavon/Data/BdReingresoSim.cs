using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdReingresoSim
{
    public int IdReingresoSim { get; set; }

    public int IdSim { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdSolicitudRecoleccionAnterior { get; set; }

    public int? IdSolicitudRecoleccionReingreso { get; set; }

    public DateTime? FecReingreso { get; set; }

    public int? IdUsuarioReingreso { get; set; }

    public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionAnteriorNavigation { get; set; }

    public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionReingresoNavigation { get; set; }

    public virtual BdUnidade IdUnidadNavigation { get; set; }
}
