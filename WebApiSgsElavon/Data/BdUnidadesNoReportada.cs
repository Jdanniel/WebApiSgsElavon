using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdUnidadesNoReportada
{
    public int IdUnidadNoReportada { get; set; }

    public int IdAuditoriaReporte { get; set; }

    public string NoSerieNoReportado { get; set; }

    public int? IdStatusSerie { get; set; }

    public virtual BdAuditoriaReporte IdAuditoriaReporteNavigation { get; set; }
}
