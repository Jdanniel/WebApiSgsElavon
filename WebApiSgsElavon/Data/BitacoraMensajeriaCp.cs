using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BitacoraMensajeriaCp
{
    public int IdCpMensajeria { get; set; }

    public string Cp { get; set; }

    public int? Solicitud { get; set; }

    public int? IdEnvio { get; set; }

    public DateTime? Fecha { get; set; }

    public int? IdResponsableDestino { get; set; }
}
