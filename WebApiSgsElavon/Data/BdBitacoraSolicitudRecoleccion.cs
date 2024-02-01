using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraSolicitudRecoleccion
{
    public int IdBitacoraSolicitudRecoleccion { get; set; }

    public int IdSolicitudRecoleccion { get; set; }

    public int? IdStatusSolicitudRecoleccionIni { get; set; }

    public int? IdStatusSolicitudRecoleccionFin { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual BdSolicitudRecoleccion IdSolicitudRecoleccionNavigation { get; set; }

    public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionFinNavigation { get; set; }

    public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionIniNavigation { get; set; }
}
