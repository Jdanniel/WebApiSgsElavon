using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ViewEfectividadCargaRegion
{
    public DateTime? FecCierre { get; set; }

    public int IdCliente { get; set; }

    public string DescRegion { get; set; }

    public int? EnTiempo { get; set; }

    public int? FueraDeTiempo { get; set; }
}
