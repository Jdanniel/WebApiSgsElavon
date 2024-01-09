using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CViaticosPmo
{
    public int IdViatico { get; set; }

    public string DescViatico { get; set; }

    public string Descripcion { get; set; }

    public int? IdConceptoPmo { get; set; }

    public int? IsAr { get; set; }

    public int? IsNotAr { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
