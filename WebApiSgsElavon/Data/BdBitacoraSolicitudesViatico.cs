using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraSolicitudesViatico
{
    public int IdBitacoraSolicitudViaticos { get; set; }

    public int IdSolicitudViaticos { get; set; }

    public int? IdStatusSolicitudViaticosIni { get; set; }

    public int IdStatusSolicitudViaticosFin { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public virtual BdSolicitudesViatico IdSolicitudViaticosNavigation { get; set; }

    public virtual CStatusSolicitudViatico IdStatusSolicitudViaticosFinNavigation { get; set; }

    public virtual CStatusSolicitudViatico IdStatusSolicitudViaticosIniNavigation { get; set; }
}
