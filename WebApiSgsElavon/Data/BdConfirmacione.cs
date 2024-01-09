using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdConfirmacione
{
    public int IdConfirmacion { get; set; }

    public int? IdCargaConfirmaciones { get; set; }

    public int? IdSolicitudViaticos { get; set; }

    public string NumConfirmacion { get; set; }

    public string Status { get; set; }

    public virtual BdCargasConfirmacione IdCargaConfirmacionesNavigation { get; set; }

    public virtual BdSolicitudesViatico IdSolicitudViaticosNavigation { get; set; }
}
