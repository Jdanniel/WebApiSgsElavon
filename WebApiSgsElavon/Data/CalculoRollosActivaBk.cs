using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CalculoRollosActivaBk
{
    public int IdTransacciones { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public int NoFiliacion { get; set; }

    public int ApprovedcCount { get; set; }

    public int Declinedcount { get; set; }

    public decimal? Total { get; set; }

    public decimal? RollosConsumidos { get; set; }

    public decimal? Rollos { get; set; }

    public int MesesDeRollos { get; set; }

    public int RollosTab { get; set; }

    public int Bloqueo { get; set; }

    public string Mensaje { get; set; }

    public int NegocioExiste { get; set; }

    public string EstatusUltServicio { get; set; }
}
