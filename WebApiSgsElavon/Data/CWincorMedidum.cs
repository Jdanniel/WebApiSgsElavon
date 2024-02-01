using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class CWincorMedidum
{
    public int IdMedida { get; set; }

    public int? IdTipoMedida { get; set; }

    public string ClaveMedida { get; set; }

    public string DescMedida { get; set; }

    public string Status { get; set; }

    public int? ReportaInstalacion { get; set; }
}
