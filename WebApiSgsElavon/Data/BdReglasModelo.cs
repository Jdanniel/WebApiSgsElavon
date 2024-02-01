using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdReglasModelo
{
    public int IdReglas { get; set; }

    public int? IdModelo { get; set; }

    public int? LetrasMin { get; set; }

    public int? LetrasMax { get; set; }

    public int? NumeroMin { get; set; }

    public int? NumeroMax { get; set; }

    public int? LongMin { get; set; }

    public int? LongMax { get; set; }

    public string Status { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
