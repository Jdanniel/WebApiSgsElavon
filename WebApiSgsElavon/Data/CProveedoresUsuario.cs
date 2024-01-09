using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CProveedoresUsuario
{
    public int IdProveedorUsuario { get; set; }

    public string DescProveedorUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }

    public int? IsCierreEspecial { get; set; }

    public int? IsReparador { get; set; }
}
