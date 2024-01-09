using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CStatusSolicitudAlmacen
{
    public int IdStatusSolicitudAlmacen { get; set; }

    public string DescStatusSolicitudAlmacen { get; set; }

    public int? IsConfirmarEntrega { get; set; }

    public int? IsHabilitaConfirmar { get; set; }

    public int? IsCancelado { get; set; }

    public int? IsFlujoAlmacen { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenFinNavigations { get; set; } = new List<BdBitacoraSolicitudesAlmacen>();

    public virtual ICollection<BdBitacoraSolicitudesAlmacen> BdBitacoraSolicitudesAlmacenIdStatusSolicitudAlmacenIniNavigations { get; set; } = new List<BdBitacoraSolicitudesAlmacen>();
}
