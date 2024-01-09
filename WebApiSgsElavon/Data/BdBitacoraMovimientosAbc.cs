using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdBitacoraMovimientosAbc
{
    public int IdBitacoraMovimientosAbc { get; set; }

    public int? IdAr { get; set; }

    public string Caja { get; set; }

    public string Afiliacion { get; set; }

    public DateTime? Fecha { get; set; }

    public string Status { get; set; }

    public string TipoMovimiento { get; set; }

    public string FolioTelecarga { get; set; }

    public string Observaciones { get; set; }
}
