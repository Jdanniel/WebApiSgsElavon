using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraNegocioMigracion
{
    public int IdBitacoraNegocioMigracion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }
}
