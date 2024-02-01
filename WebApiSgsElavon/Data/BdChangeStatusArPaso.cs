using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdChangeStatusArPaso
{
    public int IdChangeStatusAr { get; set; }

    public int? IdCarga { get; set; }

    public int? IdAr { get; set; }

    public int? IdStatusAr { get; set; }

    public int? IdUsuario { get; set; }

    public string Error { get; set; }

    public DateTime? FecAlta { get; set; }
}
