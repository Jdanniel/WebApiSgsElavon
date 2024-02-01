using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdTransferenciasPasoAccesorio
{
    public int IdTransferenciasPasoAccesorios { get; set; }

    public int? IdTransferencia { get; set; }

    public int? IdAccesorio { get; set; }

    public int? Cantidad { get; set; }

    public int? IdTipoResponsableOrigen { get; set; }

    public int? IdResponsableOrigen { get; set; }

    public int? IdTipoResponsableDestino { get; set; }

    public int? IdResponsableDestino { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FecAlta { get; set; }

    public string Error { get; set; }

    public int? IsProcesada { get; set; }
}
