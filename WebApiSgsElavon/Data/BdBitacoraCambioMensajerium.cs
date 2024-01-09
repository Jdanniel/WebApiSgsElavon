using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraCambioMensajerium
{
    public int IdBitacoraCambioMensajeria { get; set; }

    public int? IdEnvio { get; set; }

    public int? IdMensajeriaIni { get; set; }

    public int? IdMensajeriaFin { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }
}
