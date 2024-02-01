using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCargaChangeComentario
{
    public int IdCarga { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
