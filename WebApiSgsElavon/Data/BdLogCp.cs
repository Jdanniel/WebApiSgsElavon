using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdLogCp
{
    public int IdLogCp { get; set; }

    public string Cp { get; set; }

    public int? IdAr { get; set; }

    public int? IdCarga { get; set; }

    public int? Longitud { get; set; }

    public string ValStatus { get; set; }
}
