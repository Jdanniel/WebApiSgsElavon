using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSalesforceAbc
{
    public int IdSalesforceAbc { get; set; }

    public string CadenaAbc { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdAr { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Status { get; set; }
}
