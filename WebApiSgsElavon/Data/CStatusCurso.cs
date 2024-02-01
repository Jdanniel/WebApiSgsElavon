using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CStatusCurso
{
    public int IdStatusCurso { get; set; }

    public string StatusCurso { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Status { get; set; }
}
