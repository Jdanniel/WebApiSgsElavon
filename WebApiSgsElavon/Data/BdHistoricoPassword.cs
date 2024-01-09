using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdHistoricoPassword
{
    public int IdHistoricoPassword { get; set; }

    public int IdUsuario { get; set; }

    public string Password { get; set; }

    public DateOnly FecAlta { get; set; }
}
