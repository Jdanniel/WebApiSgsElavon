using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class ResumenGeneralAr
{
    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? TotalArs { get; set; }

    public int? TotalVisitas { get; set; }

    public decimal? TotalViaticos { get; set; }

    public int? TotalSolicitudesViaticos { get; set; }

    public int? TotalSinAccseso { get; set; }

    public int? TotalSinCustodia { get; set; }

    public int? TotalPendienteRefaccion { get; set; }

    public int? TotalSoporteTecnico { get; set; }
}
