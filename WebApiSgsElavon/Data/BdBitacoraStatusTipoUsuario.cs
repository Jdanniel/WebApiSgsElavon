using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraStatusTipoUsuario
{
    public int IdBitacoraStatusTipoUsuario { get; set; }

    public int? IdUsuarioCambio { get; set; }

    public DateTime? FecCambio { get; set; }

    public string Cambio { get; set; }

    public int? IdTipoUsuario { get; set; }
}
