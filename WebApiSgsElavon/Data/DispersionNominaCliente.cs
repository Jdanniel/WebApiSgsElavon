using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class DispersionNominaCliente
{
    public int Id { get; set; }

    public string Curp { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public string Cliente { get; set; }

    public double? Participacion { get; set; }
}
