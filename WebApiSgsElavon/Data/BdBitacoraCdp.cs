using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdBitacoraCdp
{
    public int IdBitacoraCdp { get; set; }

    public long? IdAr { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string NoAfiliacion { get; set; }

    public string RfcFiscal { get; set; }
}
