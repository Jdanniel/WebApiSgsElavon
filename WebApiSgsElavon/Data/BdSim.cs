using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSim
{
    public int IdSim { get; set; }

    public int IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public string NoSim { get; set; }

    public string NoImei { get; set; }

    public int? IdUnidad { get; set; }

    public int? IdCarrier { get; set; }

    public int? IdUsuarioAlta { get; set; }

    public DateTime? FecAlta { get; set; }

    public int? IdUsuarioStatus { get; set; }

    public DateTime? FecStatus { get; set; }

    public string Status { get; set; }

    public int? IdStatusSim { get; set; }

    public int? IsDisponible { get; set; }
}
