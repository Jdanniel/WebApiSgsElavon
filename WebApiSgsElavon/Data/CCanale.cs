using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CCanale
{
    public int IdCanal { get; set; }

    public string DescCanal { get; set; }

    public string Descripcion { get; set; }

    public string Status { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }
}
