using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class CadenaEnvios2
{
    public string CadenaRecibida { get; set; }

    public string Movimiento { get; set; }

    public string Afiliacion { get; set; }

    public string ClaveBanco { get; set; }

    public string NumeroCaja { get; set; }

    public string Estatus { get; set; }

    public string MotivoDeRechazo { get; set; }

    public string TerminalId { get; set; }

    public string FolioDeTelecarga { get; set; }

    public string IdentificadorGetnet { get; set; }

    public string NoArSf { get; set; }

    public string NoAr { get; set; }

    public string FolioTir { get; set; }

    public DateTime? FecRecibido { get; set; }
}
