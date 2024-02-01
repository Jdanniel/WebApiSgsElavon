using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraSolicitudDevolucion
{
    public int IdBitacoraSolicitudDevolucion { get; set; }

    public int IdSolicitudDevolucion { get; set; }

    public int? IdStatusSolicitudDevolucionIni { get; set; }

    public int? IdStatusSolicitudDevolucionFin { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public virtual CStatusSolicitudDevolucion IdStatusSolicitudDevolucionFinNavigation { get; set; }

    public virtual CStatusSolicitudDevolucion IdStatusSolicitudDevolucionIniNavigation { get; set; }

    public virtual CUsuario IdUsuarioAltaNavigation { get; set; }
}
