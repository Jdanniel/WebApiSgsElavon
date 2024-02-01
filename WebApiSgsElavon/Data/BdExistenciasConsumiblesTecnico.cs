using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdExistenciasConsumiblesTecnico
{
    public int IdExistenciaConsumibleTecnico { get; set; }

    public int IdTecnico { get; set; }

    public int IdConsumible { get; set; }

    public int? ConsumiblesRecibidos { get; set; }

    public int? ConsumiblesReportados { get; set; }
}
