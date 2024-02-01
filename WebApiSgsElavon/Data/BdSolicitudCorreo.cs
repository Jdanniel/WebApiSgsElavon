using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.Data;

public partial class BdSolicitudCorreo
{
    public int IdSolicitudCorreo { get; set; }

    public int? IdCliente { get; set; }

    public int? IdNegocio { get; set; }

    public int? IdServicio { get; set; }

    public string NoAr { get; set; }

    public string Nemonico { get; set; }

    public string NoSerieEquipo { get; set; }

    public string Imei { get; set; }

    public int? Estatus { get; set; }

    public string IdCorreo { get; set; }

    public DateTime? FechaCorreo { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string Observaciones { get; set; }

    public int? IdCarga { get; set; }
}
