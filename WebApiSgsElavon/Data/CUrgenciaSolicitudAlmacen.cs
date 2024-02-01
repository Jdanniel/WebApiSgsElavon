using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CUrgenciaSolicitudAlmacen
{
    public int IdUrgenciaSolicitudAlmacen { get; set; }

    public string DescUrgenciaSolicitudAlmacen { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacens { get; set; } = new List<BdSolicitudesAlmacen>();
}
