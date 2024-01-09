using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdUniversoSim
{
    public int IdUniversoSims { get; set; }

    public string Sim { get; set; }

    public string Linea { get; set; }

    public string Origen { get; set; }

    public string EstatusGeneral { get; set; }

    public string FechaActual { get; set; }

    public string Carrier { get; set; }

    public string Observaciones { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaCarga { get; set; }

    public string IdProceso { get; set; }

    public string StatusCarga { get; set; }
}
