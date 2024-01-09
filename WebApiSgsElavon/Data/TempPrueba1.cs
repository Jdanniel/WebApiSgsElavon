using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TempPrueba1
{
    public int IdBdMovInventarios { get; set; }

    public string NoAr { get; set; }

    public string InstalacionesElavonNoSerie { get; set; }

    public string InstalacionesElavonDescModelo { get; set; }

    public int? IdConectividadEntrada { get; set; }

    public int? IdAplicativoEntrada { get; set; }

    public string RetirosElavonNoSerie { get; set; }

    public string RetirosElavonDescModelo { get; set; }

    public int? IdConectividadSalida { get; set; }

    public int? IdAplicativoSalida { get; set; }

    public int? IdAr { get; set; }

    public int? InstalacionesIdUnidad { get; set; }

    public int? RetirosIdUnidad { get; set; }

    public string Observaciones { get; set; }

    public int? IdArchivoMovimiento { get; set; }
}
