using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdCuentasBancaria
{
    public int IdCuentaBancaria { get; set; }

    public int? IdUsuario { get; set; }

    public string NombreBanco { get; set; }

    public string NumeroCuenta { get; set; }

    public string Status { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int IdBanco { get; set; }
}
