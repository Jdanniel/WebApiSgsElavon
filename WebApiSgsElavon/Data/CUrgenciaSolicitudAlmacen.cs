using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CUrgenciaSolicitudAlmacen
{
    public int IdUrgenciaSolicitudAlmacen { get; set; }

    public string DescUrgenciaSolicitudAlmacen { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOlds { get; set; } = new List<BdSolicitudesAlmacenOld>();

    public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacens { get; set; } = new List<BdSolicitudesAlmacen>();
}
