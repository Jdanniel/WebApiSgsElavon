using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdPasoCancelacionMasivaOdt
{
    public int IdPasoCancelacionMasivaOdt { get; set; }

    public int? IdCarga { get; set; }

    public int? UsuarioAlta { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Odt { get; set; }

    public string CausaCancelacion { get; set; }

    public string Status { get; set; }

    public string Observacion { get; set; }
}
