using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdAuditoriaProcesosInterno
{
    public int Id { get; set; }

    public string Proceso { get; set; }

    public int? ErrorNumber { get; set; }

    public string ErrorMessage { get; set; }

    public string Referencia { get; set; }

    public DateTime? FecAlta { get; set; }
}
