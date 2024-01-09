using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraCancelacionOdtGetnetMic
{
    public int IdBitacoraCancelacionOdtGetnetMic { get; set; }

    public int? IdArGetnet { get; set; }

    public string Status { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string CierreSalesforce { get; set; }

    public int? IdCausaCancelacion { get; set; }
}
