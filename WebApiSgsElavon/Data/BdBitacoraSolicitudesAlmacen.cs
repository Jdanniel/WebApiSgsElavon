using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraSolicitudesAlmacen
{
    public int IdBitacoraSolicitudAlmacen { get; set; }

    public int? IdSolicitudAlmacen { get; set; }

    public int? IdStatusSolicitudAlmacenIni { get; set; }

    public int? IdStatusSolicitudAlmacenFin { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Comentario { get; set; }

    public virtual CStatusSolicitudAlmacen IdStatusSolicitudAlmacenFinNavigation { get; set; }

    public virtual CStatusSolicitudAlmacen IdStatusSolicitudAlmacenIniNavigation { get; set; }
}
