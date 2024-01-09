using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdCambioStatusAr
{
    public int IdCambioStatusAr { get; set; }

    public int? IdCliente { get; set; }

    public int? IdStatusArIni { get; set; }

    public int? IdStatusArFin { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public virtual CStatusAr IdStatusArFinNavigation { get; set; }

    public virtual CStatusAr IdStatusArIniNavigation { get; set; }
}
