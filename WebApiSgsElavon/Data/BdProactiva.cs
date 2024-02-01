using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdProactiva
{
    public int IdProactiva { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Week { get; set; }

    public string NoAfiliacion { get; set; }

    public int? LiberaYear { get; set; }

    public int? LiberaMes { get; set; }

    public int? LiberaDia { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuario { get; set; }

    public string Estatus { get; set; }
}
