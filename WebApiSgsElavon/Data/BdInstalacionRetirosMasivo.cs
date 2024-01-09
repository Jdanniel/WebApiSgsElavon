using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdInstalacionRetirosMasivo
{
    public int IdInstalacionRetirosMasivos { get; set; }

    public int? IdCargasInstalacionRetiros { get; set; }

    public string Odt { get; set; }

    public string NoAfiliacion { get; set; }

    public string NumSerieTerminalEntra { get; set; }

    public string ModeloInstalado { get; set; }

    public string NumSerieSimEntra { get; set; }

    public string AplicativoInstalado { get; set; }

    public string ConectividadInstalada { get; set; }

    public string NumeroSerieTerminalSale { get; set; }

    public string ModeloTerminalSale { get; set; }

    public string NumSerieSimSale { get; set; }

    public string AplicativoRetirado { get; set; }

    public string ConectividadRetirada { get; set; }

    public string Status { get; set; }

    public string Observaciones { get; set; }
}
