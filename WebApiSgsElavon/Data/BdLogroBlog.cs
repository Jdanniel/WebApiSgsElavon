using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdLogroBlog
{
    public int IdLogroBlog { get; set; }

    public int? IdLogro { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Comentario { get; set; }
}
