using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdQuestsCallcenter
{
    public int IdQuestsCallcenter { get; set; }

    public string Pregunta { get; set; }

    public int? IdCuestionario { get; set; }

    public int? Orden { get; set; }

    public int? IsRechazo { get; set; }
}
