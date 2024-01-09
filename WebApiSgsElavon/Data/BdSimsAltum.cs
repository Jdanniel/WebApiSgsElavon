using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdSimsAltum
{
    public int IdSimAlta { get; set; }

    public int IdCliente { get; set; }

    public int IdSolicitudRecoleccion { get; set; }

    public string NoSim { get; set; }

    public int? IdCarrier { get; set; }

    public int? IsAsignado { get; set; }

    public int? IsNumeric { get; set; }

    public int? IsNullSim { get; set; }

    public int? IsNullCarrier { get; set; }

    public int? IsProcesado { get; set; }

    public int? IsReingreso { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public string Status { get; set; }

    public int? Validacion { get; set; }

    public int? IsOtroCliente { get; set; }
}
