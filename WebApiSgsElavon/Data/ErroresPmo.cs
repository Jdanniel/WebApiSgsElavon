using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ErroresPmo
{
    public string Modulo { get; set; }

    public string Parametro { get; set; }

    public int? Errornumber { get; set; }

    public int? Errorseverity { get; set; }

    public int? Errorstate { get; set; }

    public int? Errorprocedure { get; set; }

    public int? Errorline { get; set; }

    public int? Errormessage { get; set; }

    public DateTime? Fecha { get; set; }
}
