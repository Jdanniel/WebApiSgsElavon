using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdArSlaInventario
{
    public int IdSlaInv { get; set; }

    public int? IdAr { get; set; }

    public DateTime FecInicioSla { get; set; }

    public DateTime FecFinSla { get; set; }

    public DateTime? FecReal { get; set; }

    public int IdUsuario { get; set; }

    public int? IdUsuarioMovInv { get; set; }
}
