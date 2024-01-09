using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdStoreAltaManual
{
    public int IdStoreAltaManual { get; set; }

    public int? IdAr { get; set; }

    public string Texto { get; set; }

    public DateTime? FecAlta { get; set; }
}
