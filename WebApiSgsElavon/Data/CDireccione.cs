using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CDireccione
{
    public int IdDirecciones { get; set; }

    public string DescDireccion { get; set; }

    public int? IdDireccionesJefe { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }
}
