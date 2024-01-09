using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class TmpCalificaPdf
{
    public string DescRegion { get; set; }

    public string DescCliente { get; set; }

    public string Tecnico { get; set; }

    public DateTime? FecAtencion { get; set; }

    public int IsPdf { get; set; }

    public DateTime? FecCargaPdf { get; set; }

    public string Calificacion { get; set; }

    public DateTime? Hoy { get; set; }
}
