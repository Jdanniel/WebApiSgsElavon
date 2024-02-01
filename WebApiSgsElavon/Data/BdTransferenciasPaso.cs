using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTransferenciasPaso
{
    public int IdTransferenciaPaso { get; set; }

    public int? IdTransferencia { get; set; }

    public string NoSerie { get; set; }

    public int? IdTipoResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IsProcesada { get; set; }

    public string Error { get; set; }
}
