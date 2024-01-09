using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class MfDispersionIngenierium
{
    public int Id { get; set; }

    public string Curp { get; set; }

    public int? IdCliente { get; set; }

    public double? Prorrateo { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? IdTecnico { get; set; }
}
