using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CAlmacene
{
    public int IdAlmacen { get; set; }

    public string DescAlmacen { get; set; }

    public string Descripcion { get; set; }

    public int IdZona { get; set; }

    public int IsLab { get; set; }

    public string Status { get; set; }

    public int? IdResponsable { get; set; }

    public bool? AutoNotif { get; set; }

    public int? IsPropiedadCliente { get; set; }

    public int? EnvioEmail { get; set; }

    public int? IdProveedor { get; set; }

    public virtual ICollection<BdSolicitudesAlmacenOld> BdSolicitudesAlmacenOlds { get; set; } = new List<BdSolicitudesAlmacenOld>();

    public virtual ICollection<CSubAlmacene> CSubAlmacenes { get; set; } = new List<CSubAlmacene>();
}
