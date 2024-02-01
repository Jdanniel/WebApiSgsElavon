using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdLogCargaMasivaTablaTotalProcesado
{
    public int IdLogCargaMasivaTablaTotalProcesados { get; set; }

    public int? Totalprocesado { get; set; }

    public int? Totalerrores { get; set; }

    public int? Totalregistros { get; set; }

    public DateTime? Fecha { get; set; }

    public string Nombre { get; set; }

    public int? IdCarga { get; set; }
}
