using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdNominaDetalle
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Secuencia { get; set; }

    public string Curp { get; set; }

    public string Nombre { get; set; }

    public int? IdProyecto { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Porcentaje { get; set; }
}
