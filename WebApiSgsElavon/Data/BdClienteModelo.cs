using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdClienteModelo
{
    public int IdClienteModelo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdModelo { get; set; }

    public int? IsF11 { get; set; }

    public int? IdOrden { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }
}
