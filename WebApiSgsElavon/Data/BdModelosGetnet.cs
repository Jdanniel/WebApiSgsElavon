using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdModelosGetnet
{
    public int IdModeloGetnet { get; set; }

    public int? IdModelo { get; set; }

    public string DescModelo { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
