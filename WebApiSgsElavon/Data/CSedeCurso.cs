using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CSedeCurso
{
    public int IdSedeCurso { get; set; }

    public string SedeCurso { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
