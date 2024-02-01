using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdEnviosSalesforceBusquedum
{
    public int IdEnviosSalesforceBusqueda { get; set; }

    public int? IdAr { get; set; }

    public int? IdCausa { get; set; }

    public string Comentario { get; set; }

    public int? IdUsuario { get; set; }

    public int? IsSalesforce { get; set; }

    public DateTime? FechaAlta { get; set; }
}
