using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempHorariosSantander
{
    public int? IdCliente { get; set; }

    public string NoAfiliacion { get; set; }

    public int? IdHorarioAcceso { get; set; }

    public int? IdHorarioUptime { get; set; }
}
