using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.DataTTOSD;

public partial class BdTpvsAltum
{
    public int IdTpvAlta { get; set; }

    public int IdCliente { get; set; }

    public int? IdSolicitudRecoleccion { get; set; }

    public int IdResponsable { get; set; }

    public int IdModelo { get; set; }

    public string NoSerie { get; set; }

    public string NoInventario { get; set; }

    public int? IsNueva { get; set; }

    public string NoImei { get; set; }

    public string NoSim { get; set; }

    public int? IsNullCliente { get; set; }

    public int? IsNullNoSerie { get; set; }

    public int? IsNullNoImei { get; set; }

    public int? IsNullNoSim { get; set; }

    public int? IsNullNueva { get; set; }

    public int? IsAsignada { get; set; }

    public int? IsGprs { get; set; }

    public int? IsReingreso { get; set; }

    public int? ExistsSim { get; set; }

    public int? ExistsModelo { get; set; }

    public int? IsProcesada { get; set; }

    public int IdUsuarioAlta { get; set; }

    public DateTime FecAlta { get; set; }

    public string Status { get; set; }

    public int? IdModeloAnt { get; set; }

    public int? IsCambioModelo { get; set; }

    public int? IdConectividad { get; set; }

    public int? IdAplicativo { get; set; }

    public int? IsNullConectividad { get; set; }

    public int? IsNullAplicativo { get; set; }

    public int? IdOrdenCompra { get; set; }

    public int? IsErrorSerie { get; set; }

    public string MsgErrorSerie { get; set; }

    public int? IdCarga { get; set; }
}
