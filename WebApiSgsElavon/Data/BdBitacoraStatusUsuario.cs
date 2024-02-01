using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraStatusUsuario
{
    public int IdBitacoraStatusUsuario { get; set; }

    public int? IdUsuarioCambio { get; set; }

    public int? IdUsuario { get; set; }

    public string StatusAnterior { get; set; }

    public string StatusNuevo { get; set; }

    public DateTime? FecCambio { get; set; }
}
