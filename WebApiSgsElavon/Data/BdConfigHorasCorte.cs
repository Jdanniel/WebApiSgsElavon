using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdConfigHorasCorte
{
    public int IdConfigHorasCorte { get; set; }

    public string HoraCorteEnviado { get; set; }

    public string HoraCorteRecibido { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public string Estatus { get; set; }
}
