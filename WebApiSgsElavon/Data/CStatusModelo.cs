using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusModelo
{
    public int IdStatusModelo { get; set; }

    public string DescStatusModelo { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Status { get; set; }
}
