using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CTipoSolicitudAlmacen
{
    public int IdTipoSolicitudAlmacen { get; set; }

    public string DescTipoSolicitudAlmacen { get; set; }

    public string Status { get; set; }

    public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOlds { get; set; } = new List<BdSolicitudesAlmacenOld>();

    public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacens { get; set; } = new List<BdSolicitudesAlmacen>();
}
