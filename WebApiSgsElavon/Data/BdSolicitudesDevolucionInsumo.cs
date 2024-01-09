using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSolicitudesDevolucionInsumo
{
    public int IdSolicitudDevolucionInsumo { get; set; }

    public int IdSolicitudDevolucion { get; set; }

    public int IdInsumo { get; set; }

    public string Cantidad { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsRecibidoRetorno { get; set; }

    public int? IdStatusInsumoIni { get; set; }

    public virtual CUsuario IdUsuarioAltaNavigation { get; set; }
}
